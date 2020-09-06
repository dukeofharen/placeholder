$nsisDownloadUrl = "https://kumisystems.dl.sourceforge.net/project/nsis/NSIS%203/3.06.1/nsis-3.06.1.zip"
$downloadLocation = "$($env:TEMP)\nsis.zip"
$nsisPath = "$($env:TEMP)\nsis"

if (!(Test-Path $nsisPath)) {
    Write-Host "Creating directory $nsisPath"
    New-Item -Type Directory $nsisPath
}

Write-Host "Downloading file $nsisDownloadUrl to $downloadLocation"
Invoke-WebRequest -Uri $nsisDownloadUrl -OutFile $downloadLocation

Write-Host "Extracting archive $downloadLocation to $nsisPath"
Expand-Archive -LiteralPath $downloadLocation -DestinationPath $nsisPath

Write-Host "Adding NSIS to path variable"
$env:PATH = "$nsisPath\nsis-3.06.1\Bin;$($env:PATH)"