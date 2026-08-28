FROM ghcr.io/home-assistant/base:3.24@sha256:93ef607824e3f27e868f11b10938283a98bf880ed57bcf8eaa81c6c2d521f6f5

ARG BUILD_ARCH=amd64

RUN apk add --no-cache icu-libs icu-data-full && \
    rm -rf /tmp/* /var/tmp/* /var/cache/distfiles/* && \
    mkdir -p /etc/services.d/portainer-monitor

COPY source/bin/publish/${BUILD_ARCH} .
COPY run.sh /etc/services.d/portainer-monitor/run

RUN chmod a+x /etc/services.d/portainer-monitor/run && \
    chmod a+x /HomeAssistant.Addon.PortainerMonitor
