namespace RoboTupiAP
{
    internal class Program
    {
        
        
        
        
        
        
        
        
        
        
        public static void MenuInput()
        {
            Text.MenuText();
            string answer = Console.ReadLine();
            if (answer == "1")
            {

            } else if (answer == "2")
            {
                Text.ExitMsg();
                Environment.Exit(0);
            }
        }
        
        
        
        
        
        
        static void Main(string[] args)
        {
            MenuInput();
        }
    }
}
