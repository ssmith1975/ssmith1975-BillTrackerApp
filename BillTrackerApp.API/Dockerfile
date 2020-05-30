FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 5000
EXPOSE 44388

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build
WORKDIR /src
COPY ["BillTrackerApp.API/BillTrackerApp.API.csproj", "BillTrackerApp.API/"]
RUN dotnet restore "BillTrackerApp.API/BillTrackerApp.API.csproj"
COPY . .
WORKDIR "/src/BillTrackerApp.API"
RUN dotnet build "BillTrackerApp.API.csproj" -c Release -o /app/build

FROM build AS publish
# RUN dotnet publish "BillTrackerApp.API.csproj" -c Release -o /app/publish
# WORKDIR /src
WORKDIR "/src/BillTrackerApp.API"
RUN dotnet publish "BillTrackerApp.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BillTrackerApp.API.dll"]
