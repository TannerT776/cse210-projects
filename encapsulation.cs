private string _book;
private int _chapter;
private int _verse;
private string _text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord() { /* logic here */ }
    public void Display() { /* logic here */ }
}
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide() { _isHidden = true; }
    public string GetDisplayText() => _isHidden ? "____" : _text;
    public bool IsHidden() => _isHidden;
}
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        return _verseStart == _verseEnd
            ? $"{_book} {_chapter}:{_verseStart}"
            : $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}
