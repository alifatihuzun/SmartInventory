FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["src/SmartInventory.Gateway/SmartInventory.Gateway.csproj", "src/SmartInventory.Gateway/"]
RUN dotnet restore "src/SmartInventory.Gateway/SmartInventory.Gateway.csproj"
COPY . .
WORKDIR "/src/src/SmartInventory.Gateway"
RUN dotnet build "SmartInventory.Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SmartInventory.Gateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartInventory.Gateway.dll"]
