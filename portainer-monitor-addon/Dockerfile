ARG BUILD_FROM=ghcr.io/home-assistant/amd64-base:latest
FROM $BUILD_FROM

ARG BUILD_ARCH=amd64

RUN apk add --no-cache icu-libs icu-data-full && \
    rm -rf /tmp/* /var/tmp/* /var/cache/distfiles/* && \
    mkdir -p /etc/services.d/portainer-monitor

COPY source/bin/publish/${BUILD_ARCH} .
COPY run.sh /etc/services.d/portainer-monitor/run

RUN chmod a+x /etc/services.d/portainer-monitor/run && \
    chmod a+x /HomeAssistant.Addon.PortainerMonitor

LABEL org.opencontainers.image.source=https://github.com/ChrSchu90/HomeAssistant.Addon.PortainerMonitor
LABEL org.opencontainers.image.description="Home Assistant addon for Portainer monitoring"
LABEL org.opencontainers.image.licenses=Apache-2.0