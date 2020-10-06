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


Scenario: The quantity will be 100 and price 1
Given the quantity is 100
And the price is 1
And the country code is 'DE'
Then the total amount will be 106.25

Scenario: Added country code 'de'
Given the quantity is 100 
And the price is 1
And the country code is 'de'
Then the total amount will be 106.25

Scenario: Added country code with 'De'
Given the quantity is 100
And the price is 1
And the country code is 'De'
Then the total amount will be 106.25