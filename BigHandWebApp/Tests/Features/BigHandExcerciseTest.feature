Feature: BigHandExcerciseTest

Background: 
Given I am on the homepage

Scenario: BigHand Excercise Test

Given I click on ContactUs
	And ContactUs form is displayed
	And I type 'Adnan' in first name field
	When I click submit
	Then the error message is displayed