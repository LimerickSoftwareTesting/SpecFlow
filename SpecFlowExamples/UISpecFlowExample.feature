@regression
@UIcleanup
Feature: UI SpecFlow Example
	In order to demo Specflow
	As a Tester
	I want to be able to check a Website

Background: 
	Given I go to Wikipedia English Main Page

@smoke
Scenario: Should be able to Search
	Given I have entered Limerick into the search box
	When I press search
	Then the result should be the Limerick article

Scenario Outline: Should be able to Search for any word
	Given I have entered '<word>' into the search box
	When I press search
	Then the result should be the '<word>' article

Examples: 
	| word     |
	| Limerick |