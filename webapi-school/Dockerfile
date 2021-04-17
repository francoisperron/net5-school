FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

COPY net5-school.sln ./net5-school.sln
COPY webapi-school/webapi-school.csproj ./webapi-school/webapi-school.csproj
COPY webapi-school-test/webapi-school-test.csproj ./webapi-school-test/webapi-school-test.csproj
RUN dotnet restore

COPY . .
RUN dotnet test webapi-school-test

FROM build AS publish
RUN dotnet publish webapi-school/webapi-school.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS run
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webapi-school.dll"]
