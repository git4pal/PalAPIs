#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["CustomerMaintenance.API/CustomerMaintenance.API.csproj", "CustomerMaintenance.API/"]
COPY ["CustomerMaintenance.Manager/CustomerMaintenance.Manager.csproj", "CustomerMaintenance.Manager/"]
RUN dotnet restore "CustomerMaintenance.API/CustomerMaintenance.API.csproj"
COPY . .
WORKDIR "/src/CustomerMaintenance.API"
RUN dotnet build "CustomerMaintenance.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CustomerMaintenance.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CustomerMaintenance.API.dll"]
