﻿Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Addition
Scenario: Add two numbers
	Given I have a calculator
	When I have entered "50" and "70" into the calculator and press add
	Then the result should be "120"

@AdditionOutline
Scenario Outline: Add zeroes for special cases
	Given I have a calculator
	When I enter "<value1>" and "<value2>" into the calculator and press add
	Then the result should show "<value3>" on the screen
	Examples:
	|value1|value2|value3|
	|0     |20    |20     |
	|20    |0     |20   |
	|0     |0     |0   |
