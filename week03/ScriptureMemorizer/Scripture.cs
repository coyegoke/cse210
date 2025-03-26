using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    //This method initializes the scripture by 
    //splitting the text into a list of Word objects.
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public string GetDisplayText()
    {
        return _reference.GetDisplayText() + " - " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    //This method checks if all words in the scripture are hidden.
    {
        return _words.All(w => w.IsHidden());
    }
}