# Segment SoT in C#

A Source of Truth for Segment in C#.

Requires at least .NET 7.

## Running

```
dotnet run
```

## Scaffolding

```
dotnet aspnet-codegenerator controller \
    -api \
    -async \
    --controllerName UsersController \
    --controllerNamespace SegmentSoTCSharp.Controllers \
    --model SegmentSoTCSharp.Models.User \
    --dataContext SoTContext \
    --relativeFolderPath ./Controllers
```