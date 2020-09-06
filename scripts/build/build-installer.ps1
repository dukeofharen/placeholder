$rootPath = "$PSScriptRoot/../.."
$distPath = "$rootPath/dist"
$httplZipPath = "$distPath/httplaceholder_win-x64.zip"
$nsiPath = "$PSScriptRoot/installer.nsi"

Write-Host "Determine version"
$rawVersion = Get-Content "$rootPath/version.txt"
Write-Host "Version found: $rawVersion"
[version]$version = $rawVersion

Write-Host "Extracting file $httplZipPath"
$extractPath = "$rootPath/windowsbin"
Expand-Archive -LiteralPath $httplZipPath -DestinationPath $extractPath

Write-Host "Building installer $nsiPath"
$env:BuildOutputBinDirectory = "$distPath/httplaceholder_install.exe"
$env:VersionMajor = $version.Major
$env:VersionMinor = $version.Minor
$env:VersionBuild = $version.Build
& makensis $nsiPath