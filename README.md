<img src="https://github.com/hypar-io/sdk/blob/master/hypar_logo.svg" width="300px" style="display: block;margin-left: auto;margin-right: auto;width: 50%;">

# starter
A .NET starter project for Hypar. You can see it running [here](https://explore.hypar.io/functions/hypar-dotnet-starter).

The `starter` project is a dotnet core 2.0 library project which references the [Hypar SDK](https://github.com/hypar-io/sdk) and uses the [Hypar CLI](https://github.com/hypar-io/sdk/tree/master/src/cli) to bootstrap your project.

## Prerequisites
- Install [.NET](https://www.microsoft.com/net/)

## Getting Started
- Contact beta@hypar.io to have an account created. Functions can be authored and executed locally. **A login is only required when publishing your function to the world!**
- Install [.NET](https://www.microsoft.com/net/)
- Install the [Hypar CLI](https://github.com/hypar-io/sdk/tree/master/csharp/src/cli/).
- Install an IDE. Here's a couple of options:
  - [Visual Studio Code](https://code.visualstudio.com/). It's a free IDE with great support for .net and python and it looks and acts the same on every platform (Mac, Linux, Windows), so it makes our job of supporting you slightly easier.
  - [Visual Studio Community Edition](https://visualstudio.microsoft.com/vs/community/) is great too, but it doesn't exist for Linux and is still learning to walk on the Mac.
- Clone the starter repo.  
```git clone https://github.com/hypar-io/dotnet-starter```. 
- `cd dotnet-starter`
- Edit the `hypar.json` file to describe your function. See [configuration](#configuration).
- `dotnet build`
- Use the Hypar CLI to publish your function.
```
cd <function directory>
hypar publish
```
- Preview `.glb` models generated by Hypar locally using the [glTF Extension for Visual Studio Code](https://github.com/AnalyticalGraphicsInc/gltf-vscode), or [Don McCurdy's online glTF Viewer](https://gltf-viewer.donmccurdy.com/).

## Testing
```
cd test
dotnet test
```
