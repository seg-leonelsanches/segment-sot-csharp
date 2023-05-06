# Segment SoT in C#

A Source of Truth for Segment in C#.

Requires at least .NET 7.

## Motivation

Some clients don't have a unified Source of Truth for user ids. This can be a solution.

Every time a user is created here, the service automatically forwards the user to Segment with a user id. 

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