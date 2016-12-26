# Topic: SpecFlow

## SpecFlow exercises December 2016

SpecFlow is a collaboration tool. SpecFlow is called 'Cucumber for .NET'. 

Specflow is a BDD testing framework that uses Gherkins. We will cover the basics of BDD and Acceptance tests. You will also create a Specflow test. It is open source and on Github.

## Prerequiste.

We will use Visual Studio Community edition. If you do not have it, please install it (its free).  If you have any problems we will help you get that installed. If you do not have a laptop we can pair you with another person.

[VisualStudio Community edition](https://www.visualstudio.com/vs/community/)

Install the extension 'SpecFlow for Visual Studio 2015' for this session. You can install extensions in the Visual Studio Community edition. If you are trying this at home versions are available for older versions of Visual Studio. However VS Community edition should install on Windows back to Windows7. 

If you use Linux/Mac we have a link to the [Virtual machine link for Windows 10](https://developer.microsoft.com/en-us/microsoft-edge/tools/vms/) 

## Tutorial

Start by creating a Unit Test Project.  

Lets install some nuget packages we are going to use.

Install-Package NUnit
Install-Package SpecFlow

For the UI Example
Install-Package Selenium.WebDriver
Install-Package Selenium.Support

###  1. Create a feature file
Right click on the project, Add new item, SpecFlow Feature File. 

### 2. Create a steps class
Right click on the project, Add new item, SpecFlow Step Definition.

### 3. Create a UI test using SpecFlow
Background: 
	Given I go to Wikipedia English Main Page

@smoke
Scenario: Should be able to Search
	Given I have entered Limerick into the search box
	When I press search
	Then the result should be the Limerick article

Right click on the scenario, Generate Step Definitions. 
Copy methods to clipboard.
Delete the examples from the steps class. 

Paste the methods into the class. Add the unit testing library (here "using NUnit.Framework;")

Build out the test. See the selenium example if you get stuck. 

### 4. SpecFlow scenarios

Move the driver into a [BeforeScenario hook](https://github.com/techtalk/SpecFlow/wiki/Hooks)
Close the driver in an AfterScenario hook.

Change the feature/step to search for any word rather than Limerick using a SpecFlow scenarios.

### 5. Create a Unit/Integration test using SpecFlow

Calculator example

### 6. SpecFlow tables 

Alter an example to use a SpecFlow table.

When you are complete push your new repository to git to your git account. 


## Another Example
[SpecFlow BookShop](https://github.com/techtalk/SpecFlow-Examples/tree/master/ASP.NET-MVC/BookShop)

## References
[SpecFlow website](http://www.specflow.org/)
[SpecFlow github](https://github.com/techtalk/SpecFlow)
[BDD wiki](http://behaviourdriven.org/)