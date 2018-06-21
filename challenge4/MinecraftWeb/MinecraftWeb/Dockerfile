FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY MinecraftWeb/MinecraftWeb.csproj MinecraftWeb/
RUN dotnet restore MinecraftWeb/MinecraftWeb.csproj
COPY . .
WORKDIR /src/MinecraftWeb
RUN dotnet build MinecraftWeb.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish MinecraftWeb.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MinecraftWeb.dll"]
