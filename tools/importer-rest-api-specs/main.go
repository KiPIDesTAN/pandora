package main

import (
	"fmt"
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/generator"
	"log"
	"os"
	"strings"

	git "github.com/go-git/go-git/v5"
)

const (
	outputDirectory  = "../../data/"
	swaggerDirectory = "../../swagger"
	permissions      = os.FileMode(0755)

	// only useful for testing without outputting everything
	justParse = false
)

// Use: `PANDORA_GEN_FOR_REALSIES=true go run main.go`
// or, for redirecting to a file: `PANDORA_GEN_FOR_REALSIES=true go run main.go > ~/tmp/pandora_gen.log 2>&1`

func main() {
	// works around the OAIGen bug
	os.Setenv("OAIGEN_DEDUPE", "false")

	input := GenerationData()

	swaggerGitSha, err := determineGitSha(swaggerDirectory)
	if err != nil {
		log.Printf("determining Git SHA at %q: %+v", swaggerDirectory, err)
		os.Exit(1)
	}

	debug := strings.TrimSpace(os.Getenv("DEBUG")) != ""
	if !strings.EqualFold(os.Getenv("PANDORA_GENERATE_EVERYTHING"), "true") {
		for _, v := range input {
			if err := run(v, *swaggerGitSha, debug); err != nil {
				log.Printf("error: %+v", err)
				os.Exit(1)
			}
		}
	} else {
		justLatestVersion := true
		if err := generateAllResourceManagerServices(*swaggerGitSha, justLatestVersion, debug); err != nil {
			log.Printf("error: %+v", err)
			os.Exit(1)
		}
	}

	os.Exit(0)
}

func determineGitSha(repositoryPath string) (*string, error) {
	repo, err := git.PlainOpen(repositoryPath)
	if err != nil {
		return nil, err
	}

	ref, err := repo.Head()
	if err != nil {
		return nil, err
	}

	commit := ref.Hash().String()
	log.Printf("[DEBUG] Swagger Repository Commit SHA is %q", commit)
	return &commit, nil
}

func run(input RunInput, swaggerGitSha string, debug bool) error {
	var errWrap = func(err error) error {
		log.Printf("❌ Service %q - Api Version %q", input.ServiceName, input.ApiVersion)
		log.Printf("     💥 Error: %+v", err)
		return err
	}

	if debug {
		log.Printf("[STAGE] Parsing Swagger Files..")
	}
	data, err := parseSwaggerFiles(input, debug)
	if err != nil {
		return errWrap(fmt.Errorf("parsing Swagger files: %+v", err))
	}
	if data != nil && len(*data) == 0 {
		log.Printf("😵 Service %q / Api Version %q contains no resources, skipping.", input.ServiceName, input.ApiVersion)
		return nil
	}

	if justParse {
		log.Printf("✅ Service %q - Api Version %q - Parsed Fine but skipping generation", input.ServiceName, input.ApiVersion)
		return nil
	}

	if debug {
		log.Printf("[STAGE] Updating the Output Revision ID to %q", swaggerGitSha)
	}
	if err := generator.OutputRevisionId(input.OutputDirectory, input.RootNamespace, swaggerGitSha); err != nil {
		return fmt.Errorf("outputting the Revision Id: %+v", err)
	}

	if debug {
		log.Printf("[STAGE] Generating Swagger Definitions..")
	}
	if err := generateServiceDefinitions(*data, input.OutputDirectory, input.RootNamespace, input.ResourceProvider, debug); err != nil {
		return errWrap(fmt.Errorf("generating Service Definitions: %+v", err))
	}

	if debug {
		log.Printf("[STAGE] Generating API Definitions..")
	}
	if err := generateApiVersions(*data, input.OutputDirectory, input.RootNamespace, input.ResourceProvider, debug); err != nil {
		return errWrap(fmt.Errorf("generating API Versions: %+v", err))
	}

	log.Printf("✅ Service %q - Api Version %q", input.ServiceName, input.ApiVersion)
	return nil
}
