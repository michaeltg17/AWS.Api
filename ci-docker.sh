#!/bin/bash
set -e

docker build -f Dockerfile.ci -t aws-api-ci .
docker run --rm \
    -v /var/run/docker.sock:/var/run/docker.sock \
    -e TESTCONTAINERS_HOST_OVERRIDE=host.docker.internal \
    aws-api-ci