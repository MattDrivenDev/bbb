@ECHO OFF

REM ==========================================================================
REM This batch file is run in order to download packages from NuGet
REM It is called by the CI server before the build.
REM
REM Why do this rather than do it automatically as part of the build?
REM
REM Answer: We got fed up issues with NuGet timing out so we have moved the 
REM resolution of packages out of the MsBuild step into a separate pre-build step,
REM not run as part of "build.bat"
REM
REM Also, we eliminated versions in the references -- we control the versions explicitly now
REM via the packages.config
REM ==========================================================================

REM Delete existing package folder - resolving a specific issue with Octotools still using older version
del /F /Q /S packages
rd /Q /S packages

".nuget\nuget.exe" install "packages.config" -NoCache -OutputDirectory "packages" -ExcludeVersion -Source "https://nuget.org/api/v2/"
