https://automationrhapsody.com/build-a-rest-api-with-net-core-2-and-run-it-on-docker-linux-container/


#Docker 
Firt publish 
dotnet publish --configuration=Release -o pub
##Compile
docker build . -t dotnet-rest
##Run
docker run -e Version1.1 -p:9000:5080 dotnet-rest

