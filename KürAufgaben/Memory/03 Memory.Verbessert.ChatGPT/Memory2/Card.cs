namespace MemoryGame;

class Card
{
    public char Symbol { get; private set; }
    public bool IsRevealed { get; private set; }
    public bool IsRemoved { get; private set; }

    public Card(char symbol)
    {
        Symbol = symbol;
        IsRevealed = false;
        IsRemoved = false;
    }

    public void Reveal()
    {
        IsRevealed = true;
    }

    public void Hide()
    {
        IsRevealed = false;
    }

    public void Remove()
    {
        IsRemoved = true;
        IsRevealed = true;
    }
}