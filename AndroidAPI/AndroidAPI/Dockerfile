FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AndroidAPI/AndroidAPI.csproj", "AndroidAPI/"]
RUN dotnet restore "AndroidAPI/AndroidAPI.csproj"
COPY . .
WORKDIR "/src/AndroidAPI"
RUN dotnet build "AndroidAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AndroidAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ["dotnet", "AndroidAPI.dll"]
