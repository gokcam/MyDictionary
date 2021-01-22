using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<Word ,Mean>
    {
        Word[] _words;
        Mean[] _means;

        Word[] _tempArrayWord;
        Mean[] _tempArrayMeans;

        public MyDictionary()
        {
            _words = new Word[0];
            _means = new Mean[0]; 
        }

        public void Add(Word item, Mean item2)
        {
            _tempArrayWord = _words;
            _tempArrayMeans = _means;

            _words = new Word[_words.Length + 1];
            _means = new Mean[_means.Length + 1];
            for (int i = 0; i < _tempArrayWord.Length; i++)
            {
                _tempArrayWord[i] = _words[i];
            }
            for (int i = 0; i < _tempArrayMeans.Length; i++)
            {
                _tempArrayMeans[i] = _means[i];
            }

            _words[_words.Length - 1] = item;
            _means[_means.Length - 1] = item2;
        }
        public Word[] Keys
        {
            get { return _words; }
        }

        public Mean[] Keys2
        {
            get { return _means; }
        }
    }
}
