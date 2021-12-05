#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FullStackSolution.API/FullStackSolution.API.csproj", "FullStackSolution.API/"]
RUN dotnet restore "FullStackSolution.API/FullStackSolution.API.csproj"
COPY . .
WORKDIR "/src/FullStackSolution.API"
RUN dotnet build "FullStackSolution.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FullStackSolution.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FullStackSolution.API.dll"]