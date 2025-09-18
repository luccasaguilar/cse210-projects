using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
            return _text;    

        string core = _text.TrimEnd('.', ',', ';', ':', '!', '?');
        string punct = _text.Substring(core.Length);
        return new string('_', core.Length) + punct;
    }
}