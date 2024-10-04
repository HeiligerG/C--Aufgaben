namespace MemoryGame;

class Player
{
    public int Attempts { get; private set; }

    public Player()
    {
        Attempts = 0;
    }

    public void IncrementAttempts()
    {
        Attempts++;
    }
}

struct Position
{
    public int Row { get; }
    public int Column { get; }

    public Position(int row, int column)
    {
        Row = row;
        Column = column;
    }
}
