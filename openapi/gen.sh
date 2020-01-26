#!/bin/sh
openapi-generator generate -i ./openapi.json -g csharp-netcore --package-name Todos --model-package Models --api-package Apis -o ./ 
