#!/bin/bash
cd "$(dirname "$0")"

DOCKER_FILE="Dockerfile"
CONTAINER_DIR="."
IMAGE_NAME="portainer-monitor-addon:dev"
BUILD_VERSION=1.0.0
BUILD_ARCH=amd64
BUILD_FROM=ghcr.io/home-assistant/amd64-base

NET_PROJECT=./source/HomeAssistant.Addon.PortainerMonitor.csproj
NET_RUNTIME=linux-musl-x64
NET_OUT=./source/bin/publish/${BUILD_ARCH}

dotnet publish ${NET_PROJECT} -r ${NET_RUNTIME} -p:DebugType=embedded -p:PublishSingleFile=true --verbosity normal --configuration Release --self-contained -o ${NET_OUT}

docker build --no-cache --progress=plain --pull --rm --build-arg BUILD_VERSION="${BUILD_VERSION}" --build-arg BUILD_ARCH=${BUILD_ARCH} --build-arg BUILD_FROM=${BUILD_FROM} -f ${DOCKER_FILE} -t ${IMAGE_NAME} ${CONTAINER_DIR} && \
    docker run --rm -it -v ./debug/data:/data ${IMAGE_NAME}