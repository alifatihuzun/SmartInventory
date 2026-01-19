FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["src/SmartInventory.Services.Order/SmartInventory.Services.Order.csproj", "src/SmartInventory.Services.Order/"]
RUN dotnet restore "src/SmartInventory.Services.Order/SmartInventory.Services.Order.csproj"
COPY . .
WORKDIR "/src/src/SmartInventory.Services.Order"
RUN dotnet build "SmartInventory.Services.Order.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SmartInventory.Services.Order.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartInventory.Services.Order.dll"]
