using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private static readonly Random _rng = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitWords = text.Split(' ');

        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            var visible = _words.Where(w => !w.IsHidden()).ToList();
            if (visible.Count == 0)
            {
                return;
            }

            int idx = _rng.Next(visible.Count);
            visible[idx].Hide();
        }
    }
    public string GetDisplayText()
    {
        string verse = string.Join(' ', _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}  {verse}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }    
}