FROM microsoft/dotnet:2.2-sdk 
WORKDIR /app
EXPOSE 80
# copy csproj and restore as distinct layers
#COPY *.csproj ./
COPY . ./
RUN dotnet restore

# copy and build everything else
#COPY . ./
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/MyWebApi.dll"]