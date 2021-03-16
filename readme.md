## Example project for using TinyMCE in a Blazor WebAssembly project

This repo contains an example project for integrating the TinyMCE-Editor in a Blazor WebAssembly project.

Steps:
   1. Create a blazor wasm project using dotnet cli or Visual Studio
   1. Add PackageReference to TinyMCE.Blazor nuget
    
       ``dotnet add package TinyMCE.Blazor``
   1. Add Reference to the javascript of the TinyMCE.Blazor libary to the index.html file located in the wwwroot directory

      ``<script src="_content/TinyMCE.Blazor/tinymce-blazor.js"></script>``
   1. Optional: If you want to use a local TinyMCE version you need to copy the files to the wwwroot and reference the tinymce.js file in the index.html file

      ``<script src="/tinymce/tinymce.min.js"></script>``

Now you are ready to use the TinyMCE-Editor in your Blazor WebAssembly project.

For further usage of the editor, see the official repo [here](https://github.com/tinymce/tinymce-blazor).