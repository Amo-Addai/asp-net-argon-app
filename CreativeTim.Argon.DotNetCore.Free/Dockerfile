FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["AUTO.Argon.DotNetCore.Free/AUTO.Argon.DotNetCore.Free.csproj", "AUTO.Argon.DotNetCore.Free/"]
RUN dotnet restore "AUTO.Argon.DotNetCore.Free/AUTO.Argon.DotNetCore.Free.csproj"
COPY . .
WORKDIR "/src/AUTO.Argon.DotNetCore.Free"
RUN dotnet build "AUTO.Argon.DotNetCore.Free.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AUTO.Argon.DotNetCore.Free.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AUTO.Argon.DotNetCore.Free.dll"]
