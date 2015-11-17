Feature: Google Application 
As a user of Google
I want to enter a saerch query
I should see a search result

@test
Scenario: Enter search query
Given I am on the google page
When I enter a search query "<NCC>"
Then I should see the url of NCC in the search result
	
