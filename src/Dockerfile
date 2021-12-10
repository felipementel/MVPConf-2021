#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MVPConf.ProjectOne.Api/MVPConf.ProjectOne.Api.csproj", "MVPConf.ProjectOne.Api/"]
RUN dotnet restore "MVPConf.ProjectOne.Api/MVPConf.ProjectOne.Api.csproj"
COPY . .
WORKDIR "/src/MVPConf.ProjectOne.Api"
RUN dotnet build "MVPConf.ProjectOne.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MVPConf.ProjectOne.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MVPConf.ProjectOne.Api.dll"]