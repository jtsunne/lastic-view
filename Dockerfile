FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lastic-view.csproj", "./"]
RUN dotnet restore "lastic-view.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "lastic-view.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lastic-view.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lastic-view.dll"]
