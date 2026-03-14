#!/bin/bash
cd "$(dirname "$0")" || exit

DOCKER_FILE="Dockerfile"
IMAGE_NAME="portainer-monitor-addon:dev"
BUILD_VERSION=0.0.1
BUILD_ARCH=amd64
BUILD_FROM=ghcr.io/home-assistant/amd64-base:latest
NET_PROJECT=./source/HomeAssistant.Addon.PortainerMonitor.csproj
NET_BUILD_ARGS="-p:DebugType=embedded -p:PublishSingleFile=true --verbosity normal --configuration Release --self-contained"
NET_OUT=./source/bin/publish/

dotnet publish ${NET_PROJECT} -r linux-musl-x64 ${NET_BUILD_ARGS} -o "${NET_OUT}amd64" && \
  dotnet publish ${NET_PROJECT} -r linux-musl-arm64 ${NET_BUILD_ARGS} -o "${NET_OUT}aarch64" && \
  docker build --progress=plain --rm --build-arg BUILD_VERSION="${BUILD_VERSION}" --build-arg BUILD_ARCH=${BUILD_ARCH} --build-arg BUILD_FROM=${BUILD_FROM} -f ${DOCKER_FILE} -t ${IMAGE_NAME} . && \
  docker run --rm -it -e PORTAINER_MONITOR_CONFIG="$(cat ./source/Properties/DebugConfig.json)" ${IMAGE_NAME}