Feature: Calculator

Scenario: The quantity will be 10 and price 2
Given the quantity is 10
And the price is 2
Then the total amount will be 20

Scenario: The quantity will be 10 and price 2.5
Given the quantity is 10
And the price is 2.5
Then the total amount will be 25

Scenario: The quantity will be 10.5 and price 5
Given the quantity is 10.5
And the price is 5
Then the total amount will be error


