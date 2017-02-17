using System;
using System.Collections.Generic;

 namespace RepeatCounterApp.Objects
 {
     public class RepeatCounter
     {
       private string _word;
       private string _sentence;
       private bool _legalSentence;

       public RepeatCounter(string word, string sentence)
       {
         _word = word;
         _sentence = sentence;
         _legalSentence = CheckSentenceLength();
       }

       public bool CheckSentenceLength()
       {
         if(_sentence.Length >= _word.Length)
         {
           return true;
         }
         else
         {
           return false;
         }
       }

       //Getters and Setters
       public string GetWord()
       {
         return _word;
       }
       public void SetWord(string word)
       {
         _word = word;
       }
       public string GetSentence()
       {
         return _sentence;
       }
       public void SetSentence(string sentence)
       {
         _sentence = sentence;
       }
       public bool GetLegalSentence()
       {
         return _legalSentence;
       }
     }
 }
