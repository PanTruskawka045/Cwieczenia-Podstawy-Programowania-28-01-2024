FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Zadanie 3/Zadanie 3.csproj", "Zadanie 3/"]
RUN dotnet restore "Zadanie 3/Zadanie 3.csproj"
COPY . .
WORKDIR "/src/Zadanie 3"
RUN dotnet build "Zadanie 3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Zadanie 3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zadanie 3.dll"]
