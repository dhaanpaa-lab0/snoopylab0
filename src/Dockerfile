FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ./*.sln .
COPY SnoopyLab0/. ./SnoopyLab0/
COPY Client/. ./Client/
RUN ls -lahR && dotnet restore
WORKDIR /src/SnoopyLab0/
RUN apt-get update -yq && apt-get upgrade -yq && apt-get install -yq curl git nano
RUN curl -sL https://deb.nodesource.com/setup_16.x | bash - && apt-get install -yq nodejs build-essential
RUN npm install -g npm
RUN npm install
RUN npm build
RUN dotnet publish -c release -o /app --no-restore && npm -v && ls -alh /app
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "SnoopyLab0.dll"]