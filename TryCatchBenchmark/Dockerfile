FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TryCatchBenchmark/TryCatchBenchmark.csproj", "TryCatchBenchmark/"]
RUN dotnet restore "TryCatchBenchmark/TryCatchBenchmark.csproj"
COPY . .
WORKDIR "/src/TryCatchBenchmark"
RUN dotnet build "TryCatchBenchmark.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TryCatchBenchmark.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TryCatchBenchmark.dll"]
