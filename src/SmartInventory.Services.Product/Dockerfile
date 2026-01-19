FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["src/SmartInventory.Services.Product/SmartInventory.Services.Product.csproj", "src/SmartInventory.Services.Product/"]
RUN dotnet restore "src/SmartInventory.Services.Product/SmartInventory.Services.Product.csproj"
COPY . .
WORKDIR "/src/src/SmartInventory.Services.Product"
RUN dotnet build "SmartInventory.Services.Product.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SmartInventory.Services.Product.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartInventory.Services.Product.dll"]
