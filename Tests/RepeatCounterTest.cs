using Xunit;
using RepeatCounterApp.Objects;
using System;
using System.Collections.Generic;

namespace RepeatCounterAppTests
{
    public class RepeatCounterAppTest : IDisposable
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
            string testSentence = "Here is my, great sentence.";
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

        [Fact]
        public void GetSeperateWords_ReturnsUsersSentenceBrokeIntoIndividualWords_DefinedVariable()
        {
            //arrange
            string testWord = "Great";
            string testSentence = "Hey you, man";
            string[] checkSentence = new string[] {"Hey", "you", "man"};
            string[] theSentence;
            //act
            RepeatCounter newInput = new RepeatCounter(testWord, testSentence);
            theSentence = newInput.GetSentenceWords();

            //assert
            Assert.Equal(checkSentence[2], theSentence[2]);
        }

        [Fact]
        public void CheckForWord_ReturnsTrueIfWordIsInSentence_DefinedVariable()
        {
            //arrange
            string testWord = "you";
            string testSentence = "Hey you, man";
            bool wordFound = true;
            //act
            RepeatCounter newInput = new RepeatCounter(testWord, testSentence);

            //assert
            Assert.Equal(wordFound, newInput.CheckIfWordFound());
        }

        [Fact]
        public void CountWordRepeats_ReturnTotalNumberOfWordRepeats_DefinedVariable()
        {
            //arrange
            string testWord = "you";
            string testSentence = "Hey you, you, you, you, man";
            int wordCount = 4;
            //act
            RepeatCounter newInput = new RepeatCounter(testWord, testSentence);

            //assert
            Assert.Equal(wordCount, newInput.GetWordCount());
        }

        public void Dispose()
        {
            RepeatCounter.DeleteAll();
        }
    }
}
