FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["KubernetesPoC/KubernetesPoC.csproj", "KubernetesPoC/"]

RUN dotnet restore "KubernetesPoC/KubernetesPoC.csproj"
COPY . .
WORKDIR "/src/KubernetesPoC"
RUN dotnet build "KubernetesPoC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KubernetesPoC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KubernetesPoC.dll"]
