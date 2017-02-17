using Xunit;
using RepeatCounterApp.Objects;
using System;
using System.Collections.Generic;

namespace RepeatCounterAppTests
{
    public class ClassTest
    {
        [Fact]
        public void GetWord_ReturnsUsersWord_DefinedVariable()
        {
            //arrange
            string testWord = "Great";
            string testSentence = "Here is my great sentence.";
            //act
            RepeatCounter newInput = new RepeatCounter(testWord, testSentence);
            //assert
            Assert.Equal(testWord, newInput.GetWord());
        }

        [Fact]
        public void GetSentence_ReturnsUsersSentence_DefinedVariable()
        {
            //arrange
            string testWord = "Great";
            string testSentence = "Here is my great sentence.";
            //act
            RepeatCounter newInput = new RepeatCounter(testWord, testSentence);
            //assert
            Assert.Equal(testSentence, newInput.GetSentence());
        }

        [Fact]
        public void GetLegalSentence_ReturnsUsersLegalStatusOfSentenceLength_DefinedVariable()
        {
            //arrange
            string testWord = "Great";
            string testSentence = "Good";
            bool testSentenceLength = false;
            //act
            RepeatCounter newInput = new RepeatCounter(testWord, testSentence);
            //assert
            Assert.Equal(testSentenceLength, newInput.GetLegalSentence());
        }
    }
}
