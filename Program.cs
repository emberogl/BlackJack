using BlackJack.Controller;

namespace BlackJack
{
    /// <summary>
    /// Creates Cycle instance for Controller, and runs StartGame().
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Cycle Controller = new Cycle();
            Controller.StartGame();
        }
    }
}