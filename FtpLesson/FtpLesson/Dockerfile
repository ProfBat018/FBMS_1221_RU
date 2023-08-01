FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FtpLesson/FtpLesson.csproj", "FtpLesson/"]
RUN dotnet restore "FtpLesson/FtpLesson.csproj"
COPY . .
WORKDIR "/src/FtpLesson"
RUN dotnet build "FtpLesson.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FtpLesson.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FtpLesson.dll"]
