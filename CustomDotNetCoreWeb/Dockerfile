#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CustomDotNetCoreWeb/CustomDotNetCoreWeb.csproj", "CustomDotNetCoreWeb/"]
COPY ["Web.DataAccess/Web.DataAccess.csproj", "Web.DataAccess/"]
COPY ["Web.Models/Web.Models.csproj", "Web.Models/"]
COPY ["Web.Utility/Web.Utility.csproj", "Web.Utility/"]
COPY ["WebApplicationRazor/WebApplicationRazor.csproj", "WebApplicationRazor/"]
RUN dotnet restore "CustomDotNetCoreWeb/CustomDotNetCoreWeb.csproj"
COPY . .
WORKDIR "/src/CustomDotNetCoreWeb"
RUN dotnet build "CustomDotNetCoreWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CustomDotNetCoreWeb.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CustomDotNetCoreWeb.dll"]