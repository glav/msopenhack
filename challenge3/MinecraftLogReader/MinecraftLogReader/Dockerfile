FROM microsoft/dotnet:2.0-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /src
COPY MinecraftLogReader/MinecraftLogReader.csproj MinecraftLogReader/
RUN dotnet restore MinecraftLogReader/MinecraftLogReader.csproj
COPY . .
WORKDIR /src/MinecraftLogReader
RUN dotnet build MinecraftLogReader.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish MinecraftLogReader.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MinecraftLogReader.dll"]
