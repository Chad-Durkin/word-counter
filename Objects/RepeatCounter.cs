using System;
using System.Collections.Generic;

namespace RepeatCounterApp.Objects
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;
        private bool _legalSentence;
        private bool _wordFound = false;
        private string[] _sentenceWords;
        private int _wordCount;
        private static List<RepeatCounter> _checkedCases = new List<RepeatCounter>();

        public RepeatCounter(string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
            // _legalSentence = CheckSentenceLength();
            // _sentenceWords = BreakDownSentence();
            // _wordFound = CheckForWord();
            _wordCount = CountRepeats(_word, _sentence);
            _checkedCases.Add(this);
        }

        public int CountRepeats(string word, string sentence)
        {
            if(_legalSentence = CheckSentenceLength())
            {
                _sentenceWords = BreakDownSentence();
                if(_wordFound = CheckForWord())
                {
                    return _wordCount;
                }
            }
            return 0;
        }

        public bool CheckForWord()
        {
            for(var index = 0; index < _sentenceWords.Length; index++)
            {
                if(_sentenceWords[index].ToLower() == _word.ToLower ())
                {
                    _wordCount++;
                    _wordFound = true;
                }
            }

            return _wordFound;
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

        public string[] BreakDownSentence()
        {
            char[] specialChars = {' ', '.', ',', ':', ';', '!', '?', '/', '"', '(', ')', '@', '#', '$', '%', '&', '*', '=', '_', '-', '+'};

            string[] seperateWords = _sentence.Split(specialChars, StringSplitOptions.RemoveEmptyEntries);

            foreach(string word in seperateWords)
            {
                Console.WriteLine(word);
            }

            return seperateWords;
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
        public string[] GetSentenceWords()
        {
            return _sentenceWords;
        }
        public bool CheckIfWordFound()
        {
            return _wordFound;
        }
        public int GetWordCount()
        {
            return  _wordCount;
        }
        //Clear out Objects
        public static void DeleteAll()
        {
            _checkedCases.Clear();
        }
    }
}
