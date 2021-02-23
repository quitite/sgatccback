FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine3.12

RUN apk add icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

WORKDIR /app
COPY . .

ENV ASPNETCORE_URLS=http://+:21021
ENV DOTNET_USE_POLLING_FILE_WATCHER=true

EXPOSE 21021

ENTRYPOINT ["dotnet", "SGA.Web.Host.dll"]
