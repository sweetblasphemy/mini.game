namespace mini.game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            miniGame game = new miniGame("Player", "Zombie", 40, 45, 10);

            game.print();
        }
    }
}