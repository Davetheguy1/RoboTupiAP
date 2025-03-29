using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RoboTupiAP
{
    public class GridMovement
    {
        // Valores Globais
        public static int globalXValue = 0;
        public static int globalYValue = 0;
        public static int RobotTurn = 1;
       
        // Robo 1:
        public static int R1XValue = 0;
        public static int R1YValue = 0;
        public static char R1Direction = 'N';
        public static string R1Active = "Ativo";
       
        // Robo 2:
        public static int R2XValue = 0;
        public static int R2YValue = 0;
        public static char R2Direction = 'N';
        public static string R2Active = "Inativo";

        

        public static void ExpeditionGraph(int code1, int code2)

        {
            if (code1 == 1 && code2 == 1)
            {
                Text.ShowInfo();
                Text.EnquireString1();
                Program.StringDecoder1(1);
            }
            else if (code1 == 2 && code2 == 1)
            {
                Text.ShowInfo();
                Text.EnquireString1();
                Program.StringDecoder1(2);
            }
            else if (code1 == 1 && code2 == 2)
            {
                Text.ShowInfo();
                Text.EnquireString2();
                SecondDecoder.StringDecoder2(1);
            } else if (code1 == 2 && code2 == 2)
            {
                Text.ShowInfo();
                Text.EnquireString2();
                SecondDecoder.StringDecoder2(2);
            }
            else
            {
                Text.ShowInfo();
                Program.Enquire();
            }
        }


    }
}
