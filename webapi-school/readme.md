# cmd

### rebuild
    dotnet clean && dotnet build

### test
    dotnet test webapi-school-test

### test-watch
    cd webapi-school-test
    dotnet watch test

### run
    dotnet run --project webapi-school

### run-watch
    cd webapi-school
    dotnet watch run

### docker-build
     docker build -t webapi-school:1 -f webapi-school/Dockerfile .

### docker-run
    docker run --rm --name webapi-school -p 8080:80 -d webapi-school:1
    docker stop webapi-school

# todo
- replace routing magic with explicit route declaration