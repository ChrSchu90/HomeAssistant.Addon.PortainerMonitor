ARG BUILD_ARCH=amd64
FROM ghcr.io/home-assistant/${BUILD_ARCH}-base:latest

ARG BUILD_ARCH=amd64

RUN apk add --no-cache icu-libs icu-data-full && \
    rm -rf /tmp/* /var/tmp/* /var/cache/distfiles/* && \
    mkdir -p /etc/services.d/portainer-monitor

COPY source/bin/publish/${BUILD_ARCH} .
COPY run.sh /etc/services.d/portainer-monitor/run

RUN chmod a+x /etc/services.d/portainer-monitor/run && \
    chmod a+x /HomeAssistant.Addon.PortainerMonitor
