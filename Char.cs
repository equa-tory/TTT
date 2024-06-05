namespace TTT
{
    public class Char
    {
        public Char(char _symbol = '?') { this.symbol = _symbol; }

        public char symbol { get; set; } = '?';
        public int time { get; set; } = 14;
    }
}