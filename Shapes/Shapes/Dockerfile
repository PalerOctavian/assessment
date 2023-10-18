FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Shapes/Shapes.csproj", "Shapes/"]
RUN dotnet restore "Shapes/Shapes.csproj"
COPY . .
WORKDIR "/src/Shapes"
RUN dotnet build "Shapes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Shapes.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shapes.dll"]
