<#
A script for building and packing the HttPlaceholder NuGet package.
#>
Param(
    [Parameter(Mandatory = $True)][string]$srcFolder,
    [Parameter(Mandatory = $True)][string]$distFolder
)

$versionString = $env:RELEASE_VERSION

# Create OpenAPI client for .NET
$clientSrcFolder = "$srcFolder/HttPlaceholder.Client"
& openapi-generator generate `
    -i "$distFolder/swagger.json" `
    -g csharp `
    -c "$PSScriptRoot/openapi-csharp.json" `
    -o "$clientSrcFolder" `
    --additional-properties packageVersion="$versionString"

# $clientCsprojFile = "$srcFolder/HttPlaceholder.Client/HttPlaceholder.Client.csproj"
# $binFolder = "$srcFolder/HttPlaceholder.Client/bin/Release"

# # Building NuGet packages
# & dotnet pack $clientCsprojFile -c Release
# Assert-Cmd-Ok

# Copy-Item -Path "$binFolder/*.nupkg" -Destination $distFolder