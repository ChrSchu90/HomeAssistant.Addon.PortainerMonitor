ARG BUILD_FROM 

FROM $BUILD_FROM
ARG BUILD_ARCH

RUN apk add icu-libs icu-data-full
COPY source/bin/publish/${BUILD_ARCH} .
COPY run.sh /run.sh
RUN chmod a+x /run.sh
RUN chmod a+x /HomeAssistant.Addon.PortainerMonitor
LABEL org.opencontainers.image.source=https://github.com/ChrSchu90/HomeAssistant.Addon.PortainerMonitor
LABEL org.opencontainers.image.description="Home Assistant addon for Portainer monitoring"
LABEL org.opencontainers.image.licenses=Apache-2.0
CMD [ "/run.sh" ]