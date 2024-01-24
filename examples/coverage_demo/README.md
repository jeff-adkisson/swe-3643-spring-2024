# Test Coverage Demo

This a demo project showing basic AAA pattern for unit testing.

## Running From the Command Line

1. Install [dotnet 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
2. Switch to the root directory containing the `.sln` file.
3. Execute `dotnet test` to run the tests in a console window.

## Sample Output

```console
❯ pwd
/Users/jeff/projects/3643/coverage_demo

❯ ls
MathLibrary       MathLibraryTest   README.md         coverage_demo.sln
 
❯ dotnet test
  Determining projects to restore...
  All projects are up-to-date for restore.
  MathLibrary -> /Users/jeff/projects/3643/coverage_demo/MathLibrary/bin/Debug/net8.0/MathLibrary.dll
  MathLibraryTest -> /Users/jeff/projects/3643/coverage_demo/MathLibraryTest/bin/Debug/net8.0/MathLibraryTest.dll
Test run for /Users/jeff/projects/3643/coverage_demo/MathLibraryTest/bin/Debug/net8.0/MathLibraryTest.dll (.NETCoreApp,Version=v8.0)
Microsoft (R) Test Execution Command Line Tool Version 17.8.0 (arm64)
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     2, Skipped:     0, Total:     2, Duration: 1 ms - MathLibraryTest.dll (net8.0)

```