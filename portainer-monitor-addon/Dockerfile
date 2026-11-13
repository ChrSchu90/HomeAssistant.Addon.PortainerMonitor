FROM ghcr.io/home-assistant/base:3.24@sha256:58422480a299b16b6ea376c2167463206d430619ed02b40cd687c8bd6875519e

ARG BUILD_ARCH=amd64

RUN apk add --no-cache icu-libs icu-data-full && \
    rm -rf /tmp/* /var/tmp/* /var/cache/distfiles/* && \
    mkdir -p /etc/services.d/portainer-monitor

COPY source/bin/publish/${BUILD_ARCH} .
COPY run.sh /etc/services.d/portainer-monitor/run

RUN chmod a+x /etc/services.d/portainer-monitor/run && \
    chmod a+x /HomeAssistant.Addon.PortainerMonitor
