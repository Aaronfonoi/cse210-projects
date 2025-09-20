using System;


class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public Scripture(string RefBook, int RefChapter, int RefVerse, int RefEndVerse, string RefText)
    {
        _reference = new Reference(RefBook, RefChapter, RefVerse, RefEndVerse);
        _words = new List<Word>();

        string[] splitText = RefText.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));

        }
    }
    public void Display()
    {
        Console.WriteLine($"{_reference}");
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                Console.Write(new string('_', word.GetText().Length) + " ");
            }
            else
            {
                Console.Write(word.GetText() + " ");
            }

        }
    }
    public bool HideRandomWords()
    {
        List<Word> exposedWords = GetExposedWords();
        if (exposedWords.Count < 2)
            return false;

        Random random = new Random();
        int randomIndex1 = random.Next(exposedWords.Count);
        int randomIndex2;
       


        do
        {
            randomIndex2 = random.Next(exposedWords.Count);
        }
        while (randomIndex1 == randomIndex2);

        exposedWords[randomIndex1].Hide();
        exposedWords[randomIndex2].Hide();
        return true;
        
    }

    private List<Word> GetExposedWords()
    {
        List<Word> exposedWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                exposedWords.Add(word);
        }
        return exposedWords;
    }
}