using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TicTacToe.Core;

namespace TicTacToe.Specs
{
    [Binding]
    public class TicTacToeSteps
    {
        private string[,] _board;
        private string _result;

        [Given(@"I have a tic tac toe board")]
        public void GivenIHaveATicTacToeBoard()
        {
            _board = new string[3, 3] ;
        }
        
        [Given(@"the board is empty")]
        public void GivenTheBoardIsEmpty()
        {
            _board = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        }
        
        [When(@"I determine the winner")]
        public void WhenIDetermineTheWinner()
        {
            var gameEngine = new GameEngine();
            _result = gameEngine.GetWinner(_board);
        }
        
        [Then(@"the result undetermined")]
        public void ThenTheResultUndetermined()
        {
            Assert.AreEqual(" ", _result);
        }

        [Given(@"I have ""(.*)"" across the top")]
        public void GivenIHaveAcrossTheTop(string p0)
        {
            _board[0, 0] = p0;
            _board[0, 1] = p0;
            _board[0, 2] = p0;
        }

        [Then(@"the winner is ""(.*)""")]
        public void ThenTheWinnerIs(string p0)
        {
            Assert.AreEqual(p0, _result);
        }


        [Given(@"the board looks like this")]
        public void GivenTheBoardLooksLikeThis(Table table)
        {
            _board[0, 0] = table.Rows[0]["Col1"];
        }

    }
}
