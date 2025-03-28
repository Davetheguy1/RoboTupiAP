using System.Globalization;

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
                GridInput();
            } else if (answer == "2")
            {
                Text.ExitMsg();
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Erro, Valor Invalido Informado, Pressione Enter para Retornar.");
                Console.ReadLine();
                MenuInput();
            }
        }
        
        public static void GridInput()
        {
            Text.GridMsg();
            string userInput = Console.ReadLine();
            string[] parts = userInput.Split(',');

            int XValue = int.Parse(parts[0]);
            int YValue = int.Parse(parts[1]);

            GridMovement.globalXValue = XValue;
            GridMovement.globalYValue = YValue;

            Console.WriteLine(GridMovement.globalXValue);
            Console.WriteLine(GridMovement.globalYValue);



        }
        
        
        
        
        
        static void Main(string[] args)
        {
            MenuInput();
        }
    }
}
