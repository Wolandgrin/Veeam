# CareerSearch
 Automated career search scenario for Veeam Automation engineer position.

 # Notes:
 ## Tested on Mac OS using following environment:
 ### Mac OS Catalina (10.15.4)
 ### Rider
 ### Mono (installed using Homebrew configured with "https://kenbonny.net/2018/05/28/generating-specflow-files-in-rider/")
 ### firefoxdriver (works perfectly)
 ### chromedriver v81 (works perfectly)
 ### safaridriver

 # Building the project (Mac OS + Rider)
 ## 1. Update scenarios accordingly (at the moment correct result for RO-EN vacancies is 31)
 ## 2. Remove .feature.cs file(s) and execute command from project folder: generated .feature.cs files using command: mono "packages/SpecFlow.2.4.1/tools/specflow.exe" GenerateAll -p CareerSearch.csproj
 ## 3. Clean the Build (optional)
 ## 4. Delete bin and obj folders (optional)
 ## 5. Build the project (it might be required to copy chromedriver from packages folder to bin/Debug)
 ## 6. Open Unit tests tab and launch the test
 ## 7. in case 'developer cannot be verified' error please Allow chromedriver in System preferences - Security and Privacy
 ## 8. Re-launch the test
