using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;

    private int _endVerse;


    public Reference(string RefBook, int RefChapter, int RefVerse)
    {
        this._book = RefBook;
        this._chapter = RefChapter;
        this._firstVerse = RefVerse;
        

    }
    public Reference(string RefBook, int RefChapter, int RefVerse, int RefEndVerse)
    {
        this._book = RefBook;
        this._chapter = RefChapter;
        this._firstVerse = RefVerse;
        this._endVerse = RefEndVerse;
    }

    public override string ToString()
    {
        if (_firstVerse == _endVerse)
            return $"{_book} {_chapter}: {_firstVerse}";

        else
            return $"{_book} {_chapter}: {_firstVerse}-{_endVerse}";
    }

   
}