FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Zadanie 6/Zadanie 6.csproj", "Zadanie 6/"]
RUN dotnet restore "Zadanie 6/Zadanie 6.csproj"
COPY . .
WORKDIR "/src/Zadanie 6"
RUN dotnet build "Zadanie 6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Zadanie 6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zadanie 6.dll"]
