FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Zadanie 5/Zadanie 5.csproj", "Zadanie 5/"]
RUN dotnet restore "Zadanie 5/Zadanie 5.csproj"
COPY . .
WORKDIR "/src/Zadanie 5"
RUN dotnet build "Zadanie 5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Zadanie 5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zadanie 5.dll"]
