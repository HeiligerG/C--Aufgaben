using MemoryTest;

class BoardQuestionmark
{
    static readonly string[] symbols = { "🫠", "🥩", "😶", "🥶", "🫠", "🥩", "😶", "🥶", "🫠", "🥩", "😶", "🥶", "🫠", "🥩", "😶", "🥶" };
    
    private Program program = new Program();
    
    internal string[] board = new string[16];
    private string[] actualSymbols = new string[16];

    internal void InitializeBoard()
    {
        for (int i = 0; i < 16; i++)
        {
            board[i] = " ? ";
        }
        actualSymbols = symbols.OrderBy(x => Guid.NewGuid()).ToArray();
    }

    internal void PrintBoard()
    {
        for (int i = 0; i < 16; i += 4)
        {
            Console.WriteLine($"{i + 1,2}{i + 2,2}{i + 3,2}{i + 4,2}");
            Console.WriteLine(string.Join(" ", board.Skip(i).Take(4)));
        }
        Console.WriteLine();
    }

    internal bool RevealCard(int position)
    {
        if (position < 0 || position >= 16 || board[position] != " ? ")
            return false;

        board[position] = actualSymbols[position];
        return true;
    }

    internal void HideCard(int position)
    {
        if (position >= 0 && position < 16)
            board[position] = " ? ";
    }

    internal bool CheckMatch(int pos1, int pos2)
    {
        return actualSymbols[pos1] == actualSymbols[pos2];
    }
}