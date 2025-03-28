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
        public static int globalXValue = 0;
        public static int globalYValue = 0;
        public static int RobotTurn = 1;
       
        // Robo 1:
        public static int R1XValue = 0;
        public static int R1YValue = 0;
        public static string R1Direction = "N";
        public static string R1Active = "Ativo";
       
        // Robo 2:
        public static int R2XValue = 0;
        public static int R2YValue = 0;
        public static string R2Direction = "N";
        public static string R2Active = "Inativo";

        public static void ExpeditionGraph1(int code)

        {
            if (code == 1)
            {
                Text.GridMaxValues();
                Text.robotText(1);
                Text.robotText(2);
                Text.enquireString1();
                Program.StringDecoder1(1);
            } else if (code == 2)
            {
                Text.GridMaxValues();
                Text.robotText(1);
                Text.robotText(2);
                Text.enquireString1();
                Program.StringDecoder1(2);
                //Text.enquireString2();
                // Program.StringDecoder2(1);
            }
        }     
       
        
      
       
    }
}
