using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random randomNum = new Random();
    private HashSet<int> uniqueIndexes = new HashSet<int>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] items = text.Split(' ');
        foreach (string item in items)
        {
            Word word = new Word(item);
            _words.Add(word);     // optionally could be: _words.Add(new Word(item));
        }   
    }

    public void HideRandomWords(int numberToHide)
    {
        while (numberToHide > 0)
        {
            int randomIndex = GetRandomIndex();
            if (randomIndex == -1)     // if all words are hidden
            {
                return;             
            }
            Word wordToHide = _words[randomIndex]; 
            wordToHide.Hide();
            numberToHide -= 1;    // optionally: numberToHide = numberToHide - 1; or numberToHide--;
        }
    }

    private int GetRandomIndex()
    {
        int wordsTotal = _words.Count;
        int randomNumber = -1;
        
        while (uniqueIndexes.Count < wordsTotal) 
        {
            randomNumber = randomNum.Next(0, wordsTotal);
            
            if(!uniqueIndexes.Contains(randomNumber))
            {
                uniqueIndexes.Add(randomNumber);
                return randomNumber;
            }                  
        } 
        return randomNumber; 
    }
    
    public string GetDisplayText()
    {
        string completeVerse = "";
        foreach (Word word in _words)
        {
            completeVerse += word.GetDisplayText() + " ";
        }
        string verse = _reference.GetDisplayText() + " " + completeVerse;
        return verse;
    }

    public bool IsCompletelyHidden()
    {  
        bool isAllWordsHidden = true;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                isAllWordsHidden = false;
            }
        }    
        return isAllWordsHidden;
    }
}