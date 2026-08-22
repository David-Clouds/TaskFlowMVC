# ============================================
# ETAPA 1: COMPILACIÓN
# ============================================

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ["TaskFlowMVC.csproj", "./"]

RUN dotnet restore "TaskFlowMVC.csproj"

COPY . .

RUN dotnet publish "TaskFlowMVC.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false


# ============================================
# ETAPA 2: EJECUCIÓN
# ============================================

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://0.0.0.0:10000

EXPOSE 10000

ENTRYPOINT ["dotnet", "TaskFlowMVC.dll"]