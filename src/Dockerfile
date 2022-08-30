FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ./*.sln .
COPY SnoopyLab0/. ./SnoopyLab0/
COPY Client/. ./Client/
RUN ls -lahR && dotnet restore
WORKDIR /src/SnoopyLab0/
RUN dotnet publish -c release -o /app --no-restore && npm -v

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "SnoopyLab0.dll"]