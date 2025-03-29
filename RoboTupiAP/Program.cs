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
            GridMovement.R1XValue = 0;
            GridMovement.R1YValue = 0;
            GridMovement.R1Direction = 'N';
            GridMovement.R1Active = "Ativo";

            GridMovement.R2XValue = 0;
            GridMovement.R2YValue = 0;
            GridMovement.R2Direction = 'N';
            GridMovement.R2Active = "Inativo";



            Text.GridCreateMsg();
            string userInput = Console.ReadLine();
            string[] parts = userInput.Split(',');

            int XValue = int.Parse(parts[0]);
            int YValue = int.Parse(parts[1]);

            GridMovement.globalXValue = XValue;
            GridMovement.globalYValue = YValue;

            GridMovement.ExpeditionGraph(1,1);

       
        }

        public static void StringDecoder1(int code)
        {
            string command = Console.ReadLine().ToUpper();
            string[] parts = command.Split(',');

            int XValue = int.Parse(parts[0]);
            int YValue = int.Parse(parts[1]);
            char direction = char.Parse(parts[2]);

            if (XValue > GridMovement.globalXValue || YValue > GridMovement.globalYValue)
            {
                Text.FatalError();
                Console.ReadLine();
                MenuInput();
            }

            if (code == 1)
            {
                GridMovement.R1XValue = XValue;
                GridMovement.R1YValue = YValue;
                GridMovement.R1Direction = direction;
                GridMovement.ExpeditionGraph(1,2);

            } else if (code == 2)
            {
                GridMovement.R2XValue = XValue;
                GridMovement.R2YValue = YValue;
                GridMovement.R2Direction = direction;
                GridMovement.ExpeditionGraph(2,2);

            }

            
           
        }

      
        public static void Enquire()
        {
            Text.FinalEnqString();
            string enquire = Console.ReadLine();

            if (enquire == "y")
            {
                MenuInput();

            }
            else if (enquire == "n")
            {
                Text.ExitMsg();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Erro, Favor Digitar uma Opção Válida");
                Enquire();
            }

        }







        static void Main(string[] args)
        {
            MenuInput();
        }
       
    }
}
