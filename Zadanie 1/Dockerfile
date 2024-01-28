FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Zadanie 1/Zadanie 1.csproj", "Zadanie 1/"]
RUN dotnet restore "Zadanie 1/Zadanie 1.csproj"
COPY . .
WORKDIR "/src/Zadanie 1"
RUN dotnet build "Zadanie 1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Zadanie 1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zadanie 1.dll"]
