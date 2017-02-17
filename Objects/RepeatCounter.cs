using System;
using System.Collections.Generic;

 namespace RepeatCounterApp.Objects
 {
     public class RepeatCounter
     {
       private string _word;
       private string _sentence;

       public RepeatCounter(string word, string sentence)
       {
         _word = word;
         _sentence = sentence;
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
     }
 }
