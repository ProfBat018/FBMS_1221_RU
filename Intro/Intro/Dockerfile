FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Intro/Intro.csproj", "Intro/"]
RUN dotnet restore "Intro/Intro.csproj"
COPY . .
WORKDIR "/src/Intro"
RUN dotnet build "Intro.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Intro.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Intro.dll"]
