class Scripture
{
    private readonly string reference;
    private readonly string text;
    private List<Word> words;
    private Random random;

    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        this.reference = $"{book} {chapter}:{startVerse}-{endVerse}";
        this.text = text;
        InitializeWords();
    }

    public Scripture(string book, int chapter, int verse, string text)
    {
        this.reference = $"{book} {chapter}:{verse}";
        this.text = text;
        InitializeWords();
    }

    private void InitializeWords()
    {
        words = text.Split(new char[] { ' ', ',', '.', ';', ':', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => new Word(word))
                    .ToList();
        random = new Random();
    }

    public bool AllWordsHidden
    {
        get { return words.All(word => word.IsHidden); }
    }

    public void HideRandomWord()
    {
        List<Word> remainingWords = words.Where(word => !word.IsHidden).ToList();
        if (remainingWords.Any())
        {
            Word randomWord = remainingWords[random.Next(remainingWords.Count)];
            randomWord.Hide();
        }
    }
    public override string ToString()
    {
        string displayedText = text;
        foreach (Word word in words)
        {
            if (word.IsHidden)
            {
                displayedText = displayedText.Replace(word.Text, new string('_', word.Text.Length));
            }
        }
        return $"{reference}: {displayedText}";
    }
}