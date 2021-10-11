#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["App-Server/App-Server.csproj", "App-Server/"]
COPY ["App-Services/App-Services.csproj", "App-Services/"]
COPY ["App-Database/App-Database.csproj", "App-Database/"]
RUN dotnet restore "App-Server/App-Server.csproj"
COPY . .
WORKDIR "/src/App-Server"
RUN dotnet build "App-Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "App-Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "App-Server.dll"]