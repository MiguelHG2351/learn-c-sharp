# DOTNET New console

App de consola

- --output

Indica la salida del archivo

# File .csproj

Archivo xml con la descrición del framework

# Bin

- Debug

Contiene una carpeta con la versión del framework

# Forma especial de ejecución

dotnet build -c release -r /\(win10-x64|win7-x64|osx.10.11-x64|ubuntu.16.04-x64)/

- -c -> Que se va a generar, Código de producción o depuración

Release es código de producción

- -r el sistema operativo

Posibles valores: /\(win10-x64|win7-x64|osx.10.11-x64|ubuntu.16.04-x64)/