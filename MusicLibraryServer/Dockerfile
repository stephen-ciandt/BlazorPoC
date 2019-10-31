FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MusicLibraryServer/MusicLibraryServer.csproj", "MusicLibraryServer/"]
RUN dotnet restore "MusicLibraryServer/MusicLibraryServer.csproj"
COPY . .
WORKDIR "/src/MusicLibraryServer"
RUN dotnet build "MusicLibraryServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MusicLibraryServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MusicLibraryServer.dll"]
