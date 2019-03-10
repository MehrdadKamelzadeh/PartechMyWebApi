FROM microsoft/dotnet:2.2-sdk 
WORKDIR /app
EXPOSE 80

COPY . ./
RUN dotnet restore

RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/MyWebApi.dll"]