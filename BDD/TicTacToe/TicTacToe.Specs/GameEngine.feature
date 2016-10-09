Feature: Tic Tac Toe
	In order to determine who the winner of the game as
	As a Player
	I want to be told who (if anyone) won the game

Scenario: Empty board means no winner yet
	Given I have a tic tac toe board
	And the board is empty
	When I determine the winner
	Then the result undetermined

Scenario: When X is accross the top row then X wins
	Given I have a tic tac toe board
	And I have "X" across the top
	When I determine the winner
	Then the winner is "X"

Scenario: When Y is accross the top row then Y wins
	Given I have a tic tac toe board
	And I have "Y" across the top
	When I determine the winner
	Then the winner is "Y"

Scenario: I have a board that want to figure out the winner for
	Given I have a tic tac toe board
	And the board looks like this
	| Col1 | Col2 | Col3 |
	| X    | O    |      |
	| X    |      | O    |
	| X    | O    |      |
	When I determine the winner
	Then the winner is "X"



