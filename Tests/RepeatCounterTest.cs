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
            string testString = "Here is my great sentence.";
            //act
            RepeatCounter newInput = new RepeatCounter(testWord, testString);
            //assert
            Assert.Equal(testWord, newInput.GetWord());
        }
    }
}
