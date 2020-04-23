# CareerSearch
 Automated career search scenario for Veeam Automation engineer position.

 # Notes:
 ## Tested on Mac OS using following environment:
 ### Mac OS Catalina (10.15.4)
 ### Rider (configured with file nesting settings between .feature and .feature.cs files in Solution window)
 ### Mono (installed using Homebrew and configured with "https://kenbonny.net/2018/05/28/generating-specflow-files-in-rider/")
 ### firefoxdriver (works perfectly)
 ### chromedriver v81 (works perfectly)
 ### safaridriver (not yet)

 # Building the project (Mac OS + Rider)
 ## 1. Update .feature scenarios accordingly (at the moment correct result for RO-EN vacancies is 30)
 ## 2. Remove .feature.cs file(s) and execute command from project folder: generated .feature.cs files using command: mono "packages/SpecFlow.2.4.1/tools/specflow.exe" GenerateAll -p CareerSearch.csproj
 ## 3. Clean the Build (optional)
 ## 4. Delete bin and obj folders (optional)
 ## 5. Build the project (chromedriver will be downloaded automatically in case it does not exist in Debug)
 ## 6. Open Unit tests tab and launch the test
 ## 7. in case 'developer cannot be verified' error please Allow chromedriver in System preferences - Security and Privacy
 ## 8. Re-launch the test
