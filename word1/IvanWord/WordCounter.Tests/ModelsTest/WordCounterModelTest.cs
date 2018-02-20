using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void GetInputWord_GetsInput_ReturnString()
    {
      //Arrange
      Words newWordCount = new Words("I am reapting reapting reapting reapting myself","reapting");
      string testString = "I am reapting reapting reapting reapting myself";
      //Act
      string testInputted = newWordCount.GetInputedWord();
      //Assert
      Assert.AreEqual(testString, testInputted);
    }
    [TestMethod]
    public void GetFindWord_GetsInput_ReturnString()
    {
      //Arrange
      Words newWordCount = new Words("I am reapting reapting reapting reapting myself","reapting");
      string testString = "reapting";
      //Act
      string testInputted = newWordCount.GetCompareWord();
      //Assert
      Assert.AreEqual(testString, testInputted);
    }
    [TestMethod]
    public void RepeatCounter_GetsCount_ReturnInt()
    {
      //Arrange
      Words newWordCount = new Words("I am reapting reapting reapting reapting","reapting");
      int testCounter = 4;
      //Act
      int testInputted = newWordCount.RepeatCounter();
      //Assert
      Assert.AreEqual(testCounter, testInputted);
    }
  }
}
