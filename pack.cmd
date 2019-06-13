IF EXIST "./deploy" RMDIR "./deploy" /s /q
dotnet cake -target=pack
