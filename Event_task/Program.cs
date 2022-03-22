using System;

namespace Event_task // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeyHandler keyHandler = new KeyHandler();
            keyHandler.OnKeyPressed += KeyOutput;

            keyHandler.Run();
        }

        static void KeyOutput(object sender, char key)
        {
            Console.WriteLine("\nYour symbol: " + key);
        }
    }

    class KeyHandler
    {
        public event EventHandler<char> OnKeyPressed;
        private char key;

        public void Run()
        {
            do
            {
                Console.Write("Enter symbol: ");
                key = Console.ReadKey().KeyChar;
                if (key == 'c')
                {
                    Console.WriteLine("\nExit from program");
                    break;
                }

                OnKeyPressed(this, key);
            } while (true);
        }
    }
}