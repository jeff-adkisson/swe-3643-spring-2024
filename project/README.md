# KSU SWE 3643:<br/>Software Testing and Quality Assurance<br/>Semester Project

You will execute a semester project to help reinforce some of the testing concepts covered this semester and gain valuable coding practice and source control usage along the way.

The project includes:

-  Creating a simple web-based calculator that does basic floating point calculations on single and double operands, including:

   -  Add, subtract, multiply, divide, equals, power, log, root, and factorial
   -  Reciprocal, sin, cosine, and tangent

   Your web-based calculator can be built in Java, C#, or Python. You will follow the [Test Driven Development (TDD) methodology](https://testdriven.io/test-driven-development/) to create your calculator logic and unit test it independent from the UI/web interface. To facilitate unit testing, your calculator logic will be *referenced* by the web-based UI - not tightly coupled into your UI code.

-  Adding unit tests to the calculator classes (the classes that perform the calculations) to achieve 100% coverage of the calculation methods.

-  Perform automated end-to-end testing on your web-based UI using [Playwright](https://playwright.dev/) scripts.

-  Produce a 5 to 8 minute video demonstrating your completed application, a demonstration of running your unit tests and Playwright scripts from the command line, and show that you reached 100% coverage of your calculator logic using your IDE.

## The Application

### Browser Interface

Your web application will perform simple calculations on one or two operands. The [browser interface](https://app.moqups.com/MvLts3wDDVQ8TNQBIdQN5nOCilbNhjYo/view?ui=0) will look like the following:

[![image-20240129063708596](README.assets/image-20240129063708596.png)](https://app.moqups.com/MvLts3wDDVQ8TNQBIdQN5nOCilbNhjYo/view?ui=0)

When valid input is available in one or both of the input fields and you click an operator button in a browser, the application will compute the value on the server and display the calculation and result in the highlighted result box as follows:

[![image-20240129063758115](README.assets/image-20240129063758115.png)](https://app.moqups.com/MvLts3wDDVQ8TNQBIdQN5nOCilbNhjYo/view?ui=0)

If you enter invalid data, such as attempting to divide by 0, the result box will turn red and display **Not a Number**:

[![image-20240129063816332](README.assets/image-20240129063816332.png)](https://app.moqups.com/MvLts3wDDVQ8TNQBIdQN5nOCilbNhjYo/view?ui=0)

If you enter text in one of the input boxes, the result box will turn red and display **Invalid Input, Numbers Only**:

[![image-20240129064025364](README.assets/image-20240129064025364.png)](https://app.moqups.com/MvLts3wDDVQ8TNQBIdQN5nOCilbNhjYo/view?ui=0)

Clicking the **Clear** button will reset the result box, and the input boxes to their default state.

[Please review the prototype user interface at this link.](https://app.moqups.com/MvLts3wDDVQ8TNQBIdQN5nOCilbNhjYo/view?ui=0) You can move through the interface examples by clicking anywhere on the pages.

### Architecture

Your application will separate calculation logic from web logic. This will simplify unit testing, help your code achieve the single responsibility principle, and decouple the logic engine from the user interface.

[![image-20240128222116749](README.assets/image-20240128222116749.png)](https://www.plantuml.com/plantuml/uml/VL9DQzj04BthLmp99IQnstCf9R9II0fnJAsabq9Oxqxa9QDTiHzMGyb_hwQAy1fRteFNmxptTkOzNViWN8WrPOB8jhN-eqsLPOsGhw92E2i4oKWYM0VVJQKDmlAZzGaMeaRV8V4CpabNcx2cYDdV3BeZINWFE_O7kM_okOHSgOiNiYA0DaqC-HKarNpILmd-8MpGbQrzQD09e-unRApo5xFPR98bi9KsUx8ZGXsi8ZocnQ3tB7i_wSAZqG5AzC73LWlumVKLBFeBWvmDdhmX-ygkZ7Z2b5weD-Vo0F7SEULpOTJy-IU6w8nVnVfYCeQ-qLkjy3_Xyq1Os90lOhr6npnU3quCCfr-E-YE6l8Brx12jqK7UTCSVWhzrlTM8VbT_QInJSh2ck0i4JhFewKrJpF03nk3RjePMM0qK3KjxRIxaZoN9DvQnulivmZ7SrIbvPyanRrW7k-I26-qRpfrNrZdK8OdGH4vb8Ga0Z5fFyc1bqPvzAc2j7pr1Q5mNVmUWxyp0TsBaBWB7qRdP-zIBx_0RLak6KvipMy3joWKeVSmTxRrwDXPIJOgE4zSscY58BMJXBrd2G66V_3rn7EiUur6nPh-0G00)

You will note:

-  The Calculator Engine performs the actual logic and returns floating point values.
-  The Calculator Web Server App references the Calculator Engine. The Web Server App generates the user interface, calls the Calculator Engine, and returns results to the user's browser.
-  The Calculator Engine Unit Tests reference the Calculator Engine and do not test the Web Server App.
-  The Calculator End-to-End Tests connect to your Web Server App and test the user interface end-to-end (which includes calling the Calculator Engine).

You must carefully layout your code to achieve this architecture. In particular, you cannot closely couple the calculator logic with the calculator UI. For example, if you actually perform a calculation in the Web Server App, you are doing it wrong. The Web Server App requests calculations from the Calculator Engine classes.

Without a logical separation of the Calculator Engine from the Web Server App, you will have a very challenging time writing unit tests that only focus on the Calculator Engine. Remember - unit tests focus on classes and methods. Higher level forms of tests such as integration tests and end-to-end tests combine multiple modules and systems together. To write effective unit tests, you cannot mix web server routing and rendering logic with your domain logic.

### Languages, Web Server Architectures, and Test Runners

Your choice of languages, server architectures, and test runners includes:

-  C#
   -  ASP.NET MVC + NUnit + Playwright
   -  ASP.NET Blazor Server + NUnit + Playwright
-  Java
   -  Spring MVC + JUnit + Playwright
   -  Struts + JUnit + Playwright
   -  Grails + JUnit + Playwright
-  Python
   -  Flask + Pytest + Playwright

#### I'm Freaking Out! I've Never Done Web Development! What Should I Pick?

Every framework listed has huge communities of developers who have posted outstanding tutorials on the web and on sites like YouTube. You will have no trouble finding resources. You must make the time to try the tutorials and learn the basics of what you choose. This is exactly how professional engineers operate when they are assigned a new project. I often purchase a cheap course from Udemy when learning a new technology. They have excellent material and the cost is often less than $20.

#### Are You Going to Teach Me Everything I Need to Know?

No. Your First Year instruction gave you the programming basics you need to execute this project. You also have some experience with projects and working in teams from Software Engineering 1.

You will have to watch some YouTube videos and do some independent research. This is how the real world works. Your future employer is not going to take you by the hand with every new project.

No one can teach you how to program. The only way to be a good programmer is to do the work. Sometimes that will mean long, frustrating nights at your computer working out problems and endlessly researching obscure compiler errors. Everyone in this field has had those days and nights.

You can do this. Be confident in yourself and budget your time wisely. I am here to help you, but you must do the work.

#### I Know React/Angular/Vue/otherSPAFrameworkHere. Can I Use That?

No. You must use a server framework that renders HTML on the server. SPA development is prohibited due to complexity and higher risk of overall project failure.

### Source Control

Your project will be hosted on a public GitHub repository. Each team will have a separate GitHub repository created by the team member(s).

If you have never used source control, watch some videos on `git` and create a free GitHub account. If you are uncomfortable working with command line tools, install GitHub Desktop or GitKraken (my personal preference) to give you a friendly interface.

`git` is *essential* for all software engineers regardless of industry and skill level. Do not graduate without expertise in source control, including proficiency in branching, merging, and pull requests. Note that these more advanced topics are not taught by KSU, so you need to make this a personal goal. Use this project to get started learning `git` and carry your knowledge forward after the course ends.

The best developers *always use source control even when working alone*. It is an essential skill you must develop.

### Documentation

All documentation will be written in [Markdown](https://www.markdownguide.org/) and checked into your team GitHub repository.

Project documentation will include a README.md file in the root directory of your GitHub repository that includes:

-  A short description of what is in the repository.
-  Instructions how to build and execute the application from the command line, including all environment dependencies.
-  Instructions how to execute the unit tests and Playwright tests from the command line.
-  A link to your Final Video Presentation.

Writing Markdown is easy. I highly recommend writing Markdown using an IDE with a Markdown plugin (all JetBrains IDEs support this), Visual Studio Code with a Markdown extension, or Typora.

I am a big fan of [Typora](https://becomeawritertoday.com/typora-review/). It is cross platform, visually clean, and has strong spell checking (a curiously unique feature in the Markdown world). I recommend giving it a try. I use it for all of my work. It is a licensed tool, but the cost is very low ($15!).

Markdown is not tool specific, so whether you use Typora, an IDE, VS Code, or even write it by hand, the output will (generally) operate identically.

Great engineers are great communicators. We have to reliably communicate very complex ideas to a large number of people. Learn to write effectively and get the best writing tools you can afford. Be opinionated and passionate about the tools you use... they say a lot about you (I always ask what tools people love in interviews).

#### The KSU Writing Center

Do not forget that you get extra credit for visiting the [KSU Writing Center](https://writingcenter.kennesaw.edu/) up to two times. This will help you learn to be a better writer and communicator. Towards the end of the semester after you have pounded out your project documentation, go to the KSU Writing Center and have them help you polish your work. The best documentation is thorough, concise, well-organized, and targeted at a specific audience. I recommend taking advantage of this free resource, both for the expertise you might gain and the extra credit you might want if you find yourself with a borderline grade.

### Final Video Presentation

Your completed project will include a 5 to 8 minute video presentation that demonstrates your running application, executing your unit tests and playwright tests from a terminal/command line, and demonstrating 100% code coverage from your IDE.

Your presentation can be hosted on a public link at YouTube or Vimeo or you can check in the video file to your team GitHub repository.

Avoid producing a terrible, dull, hard to understand video. I have to watch dozens of these, so have pity. 

Put some effort into this to make it organized, succinct, and interesting. Consider writing a script and perhaps use a PowerPoint presentation to frame each section of your video. Every semester someone does a video that just blows me away. It's a good skill to develop because it really helps you showcase your work and promote yourself.

### Submission Schedule

The project is due on Friday April 26th at 11:59 PM. At that time, all GitHub repositories will be automatically cloned by the instructor for grading.

To help you stay on schedule, you will submit two progress reports on the following dates explaining where you are in the project. 

-  Progress Report 1 - Monday 3/18<br/>

   I recommend having your web application fully operational by this point.

-  Progress Report 2 - Monday 4/15<br/>I recommend having 100% unit test coverage by this point.

-  Project Submission - Friday 4/26 at 11:59 PM

   Late submissions follow the penalties outlined in the Syllabus.

Each progress report is 1.5% of your overall project score. You will submit them via a D2L dropbox. These are obviously very easy points towards your project.

You do not have to be on the schedule I recommend, but you should do your best to be close. Waiting until the last minute to do this project will likely result in a very poor grade. The last four lecture periods are dedicated work days and I will be available to assist you at that time, but if you are starting from zero at that point, there will not be much I can do to help you. I am available to help you with problems - not help you build your application at the last minute.

### Grading

I will grade your project between the submission date and the day final grades are due. This will be a significant effort, so please do not submit late if you can avoid it (plus your grade will suffer as well).

This project is 25% of your semester grade, so it is essential that you give it appropriate time and effort.

I also will remind you that your final grade can only be one letter grade higher than your project, so if you do poorly on the project, you will do poorly overall.

My recommendation is to focus on doing an outstanding project and do not worry about the grade. If your project meets the requirements in this document, not only will you receive a top score, but you will have earned valuable expertise and enhanced your GitHub repository with a great looking project.

### Collaboration

You can collaborate with your teammate, but not with other teams. Each team's work must be their own.

If you choose to work alone, you are committing to that decision for the duration of the project. You cannot change your mind later.

Do not consider outsourcing your project to a homework help site like Chegg. I have had that happen before. I am pretty good at spotting unusual work and I will be reading your code. If I suspect your work is not your own, I will ask you to join me on a video call and explain your work line by line. If I remain unconvinced the work is yours, I will ask my KSU colleagues to do additional reviews.

AI tools such as ChatGPT cannot help you much with this project. But even if they can, you are cheating yourself of valuable experience you will need after you graduate. Do your own work and be a top engineer. AI is going to continue to reshape our profession, but the top engineers will remain the ones who know how to prompt an AI and recognize when it is making a mistake.

# Detailed Instructions

**Coming Soon**

-  How to sign up your team (Google Spreadsheet) and report the URL of your team Github repository
-  How to structure the project (generally - this will vary by language and framework)
-  What the UI logic will do
-  What/how man unit tests I expect and how to write them<br/>https://osherove.com/blog/2005/4/3/naming-standards-for-unit-tests.html
-  What/how many Playwright tests I expect and how to write them
-  What should be in the project README
-  What I expect in the video presentation

# Grading Rubric

**Coming Soon**

-  Did the README explain exactly how to configure the environment and execute the project?
-  Is the code structured in a way that separates logic from presentation to facilitate unit testing?
-  Does the project run from the command line?
-  Do the unit tests run from the command line?
-  Do the end-to-end tests run from the command line?
-  Did the project meet the UI requirements?
-  Did the project meet the unit test requirements?
-  Did the project reach 100% unit test coverage of the calculator logic?
-  Did the project meet the end to end Playwright testing requirements?
-  Was the presentation well organized and professionally executed?

