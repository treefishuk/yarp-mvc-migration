# YARP MVC Migration

An attempt to implement the Stranger Fig Pattern, using an old Net Framework MVC App and new Net6 MVC App.

## Background

I heard a talk from Mark Rendle on DotNet Rocks about migrating a .Net Framework App to the new .Net. You can check that out [Here](https://www.dotnetrocks.com/?show=1728).

The idea is to implement something called the [Strangler Fig pattern](https://docs.microsoft.com/en-us/azure/architecture/patterns/strangler-fig) which allows for incremental upgrades rather then going for the "Big Bang" approach which takes a lot of up front dev time. 

## What's in the repo?
- A Net Framework Legacy MVC App
- A Net 6 App with [YARP](https://microsoft.github.io/reverse-proxy/) installed and pointing to the Framework App

## Goal

To have seemless transitions between new Net MVC routes and legacy Net Framework routes. 

# Update 03/07/2022

Microsoft must have been getting this a lot because they have updated thier tooling to support just that (in preview at time of update):

Nuget Package Required: Microsoft.AspNetCore.SystemWebAdapters

Documentation: 

https://devblogs.microsoft.com/dotnet/incremental-asp-net-migration-tooling-preview-2/

I have updated the codebase and all seems to work as expected. 
