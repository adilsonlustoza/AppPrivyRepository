#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AppPrivy.WebApiDoacaoMais/AppPrivy.WebApiDoacaoMais.csproj", "AppPrivy.WebApiDoacaoMais/"]
RUN dotnet restore "AppPrivy.WebApiDoacaoMais/AppPrivy.WebApiDoacaoMais.csproj"
COPY . .
WORKDIR "/src/AppPrivy.WebApiDoacaoMais"
RUN dotnet build "AppPrivy.WebApiDoacaoMais.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AppPrivy.WebApiDoacaoMais.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AppPrivy.WebApiDoacaoMais.dll"]