cd ..
cd WebMarket.Common
dotnet restore
cd ..
cd WebMarket.DTO
dotnet restore
cd ..
cd WebMarket.EF
dotnet restore
cd ..
cd WebMarket.DAL
dotnet restore
cd ..
cd WebMarket.Services
dotnet restore
cd ..
cd WebMarket.WebApi
dotnet restore
cd ..
cd WebMarket.Web
call npm install
dotnet restore
cd ..
PAUSE