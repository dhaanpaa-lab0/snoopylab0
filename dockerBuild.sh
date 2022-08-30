#!/usr/bin/env bash
cd ./src
docker build -t snoopy-lab0 .
docker tag snoopy-lab0 dennoc/snoopy-lab0
docker push dennoc/snoopy-lab0

