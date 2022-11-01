# [ST.NSwag.ServerSourceGenerator](https://github.com/s-tarasov/ST.NSwag.ServerSourceGenerator) 

Generates Web API/ASP.NET Core controllers from a OpenAPI specification.

This package is source generator for great [nswag tool](https://github.com/RicoSuter/NSwag). 
Inspired by [H.NSwag.Generator](https://github.com/HavenDV/H.NSwag.Generator)

### Install
```
Install-Package ST.NSwag.ServerSourceGenerator
```

### Usage
1. Put openapi specification in project dir and add AdditionalFiles tag to project

```xml
<ItemGroup>
        <AdditionalFiles Include="example.openapi.yaml" />
</ItemGroup>
```
or link specification outside project dir

```xml
<ItemGroup>        
        <AdditionalFiles Include="..\specs\linkedExample.openapi.yaml" Link="linkedExample.openapi.yaml" />
</ItemGroup>
```
2. Add .nswag settings file in project dir with exact same name.  
Example: example.openapi.yaml -> example.openapi.yaml.nswag

### Faq
- How to generate or edit .nswag file?
> Use [NSwagStudio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) 
