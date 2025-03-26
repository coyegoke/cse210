class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide() //This ensure/marks a word as hidden.
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
    //This displays either the word itself or an underscore version of the word if hidden.
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}