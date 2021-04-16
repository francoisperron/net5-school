FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["docker-school/docker-school.csproj", "docker-school/"]
RUN dotnet restore "docker-school/docker-school.csproj"
COPY . .
WORKDIR "/src/docker-school"
RUN dotnet build "docker-school.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "docker-school.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "docker-school.dll"]
