using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class Words
  {
  private string _inputword;
  private string _compareWord;
  private int _counter;

  public Words (string inputedWord, string compareWord)
  {
    _inputword = inputedWord;
    _compareWord = compareWord;
  }

  public string GetInputedWord()
  {
    return _inputword;
  }
  public string GetCompareWord()
  {
    return _compareWord;
  }

  public int RepeatCounter()
  {
    _counter = 0;
    string Word = _compareWord;
    String[] Array = _inputword.Split();
    foreach(string _compareWord in Array)
    {
       if(_compareWord == Word)
       {
         _counter += 1;

       }
    }
    return _counter;
    }
  }
}
