FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Zadanie 4/Zadanie 4.csproj", "Zadanie 4/"]
RUN dotnet restore "Zadanie 4/Zadanie 4.csproj"
COPY . .
WORKDIR "/src/Zadanie 4"
RUN dotnet build "Zadanie 4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Zadanie 4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zadanie 4.dll"]
