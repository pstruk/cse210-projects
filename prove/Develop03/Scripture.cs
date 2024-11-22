using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> words = new List<Word>();
        words.Add(new Word("Proverbs"));
        return words;
    }

    public void HideRandomWords(int numberToHide)
    {
        numberToHide = 3;
    }

    public string GetDisplayText()
    {
        return "string";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}