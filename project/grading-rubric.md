#### KSU SWE 3643:<br/>Software Testing and Quality Assurance<br/>Semester Project

[**Back to Project Overview**](README.md)

# Grading Rubric

#### Team Selection: 2%

-  2%: Team selection performed on time by submitting team information to the project spreadsheet.

#### Project Checkpoints: 3%

-  1.5%: Was checkpoint 1 submitted on time to the D2L dropbox?
-  1.5%: Was checkpoint 2 submitted on time to the D2L dropbox?

#### Source Control: 5%

-  5%: Git repository arranged per specification
   -  README.md in root
   -  .gitignore in root
   -  `/src` folder with all source code for four project modules

#### Coding Standards: 5%

-  5%: All projects in the `/src` folder follow proper language conventions and structure

#### Documentation: 5%

-  5%: All documentation described in the specification is present, internally linked via a Table of Contents, contains the required material, and is grammatically correct. Important images, such as the architecture diagram, are visible - not just linked.

   Markdown is correctly formatted with headings, code blocks, relative links (where appropriate), etc.

#### Architecture: 10%

-  10%: The source is split into four modules - web app, calculator logic, unit tests, and end-to-end tests following your language's convention for arranging and referencing modules.

#### Calculator Logic: 15%

-  15%: All calculator methods are implemented and detect success and failure conditions as appropriate.

#### Calculator Unit Tests: 25%

-  2.5%: The unit test module references the calculator logic. Calculator logic is *not* tightly coupled with unit test logic. Test logic and calculator logic are strictly separated between the unit test and calculator logic modules.
-  15%: All calculator methods have one or more related unit tests. All paths are tested, including success and failure paths. All unit tests follow the naming convention from the specification and implement the AAA pattern.
-  7.5%: All calculator logic achieves 100% test coverage (as demonstrated in your IDE during your video demonstration). Coverage must test all logic, so carefully review code for 100% path coverage (including ternary conditions, if present).

#### Web Server App: 15%

-  2.5%: The web server app references the calculator logic. Calculator logic is *not* tightly coupled with UI logic. UI logic and calculator logic are strictly separated between the web app and the calculator logic module.
-  5%: The web server app can perform single and double operand operations such as add (2 operands) and sin (single operand).
-  2.5%: The web server app can show error conditions such as division by zero, returning "Not a Number."
-  2.5%: The web server app implements a clear function to reset the app to the default state.
-  2.5%: The web server app user interface matches the specifications, including layout, colors, and navigation.

#### End-to-End Testing: 10%

-  2.5%: The end-to-end-test module does not directly reference the web server module (or the calculator logic and unit test modules). The end-to-end test module only references the web server module via the running server's URL.
-  7.5%: All end-to-end tests listed in the specification are written and operational. All end-to-end tests follow the method naming convention from the specification. 

#### Extra Credit: Static Analysis: 5%

-  5%: Perform static analysis via SonarQube Community Edition. Include your analysis per the specification in your documentation and video presentation.

*You must complete every other section of the project to be eligible for extra credit in this section. Do not skip one section with the intention of making up for the loss with this section.*

*You must complete all  Static Analysis requirements to receive extra credit. This section is all or nothing.*

#### Final Presentation: 5%

5% if complete, -25% penalty if not included

-  The video meets all specifications, including executing your application, unit tests, and end-to-end tests from a command line/terminal (you only demonstrate coverage from your IDE). The video is available on YouTube or Vimeo or is checked into your GitHub repository.

*The video presentation has a minimal score value, but it is an important part of grading. If some or all of your project does not work, the video is your best method to demonstrate some mastery of the material and receive partial credit.*

*Failure to submit the video will result in a penalty of 25%.*

#### Minimal Path to Success

You can achieve a 75% score on the project by completing all sections except the web server app and end-to-end testing.

If you choose to drop sections, be sure the sections you perform are polished and demonstrate close adherence to the specifications.

Do not drop the video presentation. Failure to submit a video presentation will result in a 25% penalty.

Projects with dropped sections are not eligible for extra credit.

