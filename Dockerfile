FROM mcr.microsoft.com/dotnet/core/sdk:2.2
COPY pub/ /root/
WORKDIR /root/
ENV ASPNETCORE_URLS="http://*:5080"
EXPOSE 5080/tcp
ENTRYPOINT ["dotnet", "DotnetAndDocker.dll"]