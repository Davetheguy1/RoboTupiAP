using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiAP
{
    class SecondDecoder
    {
        public static void StringDecoder2(int code) // desculpa pelo tamanho disso.
        {
            string command = Console.ReadLine().ToUpper();
            char[] series = command.ToCharArray();

            if (code == 1)
            {
                for (int i = 0; i < series.Length; i++)
                {
                    char inspectedValue = series[i];
                    if (GridMovement.R1XValue > GridMovement.globalXValue)
                    {
                        GridMovement.R1XValue = GridMovement.globalXValue;
                        break;
                    }
                    else if (GridMovement.R1YValue > GridMovement.globalYValue)
                    {
                        GridMovement.R1YValue = GridMovement.globalYValue;
                        break;
                    }
                    
                    else if (inspectedValue == 'M' && GridMovement.R1Direction == 'N')
                    {
                        GridMovement.R1YValue = GridMovement.R1YValue + 1;
                    }
                    else if (inspectedValue == 'M' && GridMovement.R1Direction == 'S')
                    {
                        GridMovement.R1YValue = GridMovement.R1YValue - 1;
                    }
                    else if (inspectedValue == 'M' && GridMovement.R1Direction == 'L')
                    {
                        GridMovement.R1XValue = GridMovement.R1XValue + 1;
                    }
                    else if (inspectedValue == 'M' && GridMovement.R1Direction == 'O')
                    {
                        GridMovement.R1XValue = GridMovement.R1XValue - 1;
                    }
                    
                    else if (inspectedValue == 'E' && GridMovement.R1Direction == 'N')
                    {
                        GridMovement.R1Direction = 'O';
                    }
                    else if (inspectedValue == 'E' && GridMovement.R1Direction == 'O')
                    {
                        GridMovement.R1Direction = 'S';
                    }
                    else if (inspectedValue == 'E' && GridMovement.R1Direction == 'S')
                    {
                        GridMovement.R1Direction = 'L';
                    }
                    else if (inspectedValue == 'E' && GridMovement.R1Direction == 'L')
                    {
                        GridMovement.R1Direction = 'N';
                    }
                    
                    else if (inspectedValue == 'D' && GridMovement.R1Direction == 'N')
                    {
                        GridMovement.R1Direction = 'L';
                    }
                    else if (inspectedValue == 'D' && GridMovement.R1Direction == 'L')
                    {
                        GridMovement.R1Direction = 'S';
                    }
                    else if (inspectedValue == 'D' && GridMovement.R1Direction == 'S')
                    {
                        GridMovement.R1Direction = 'O';
                    }
                    else if (inspectedValue == 'D' && GridMovement.R1Direction == 'O')
                    {
                        GridMovement.R1Direction = 'N';
                    }
                    

                }
                
                GridMovement.R1Active = "Inativo";
                GridMovement.R2Active = "Ativo";
                GridMovement.ExpeditionGraph(2, 1);
            }
            else if (code == 2)
            {
                for (int i = 0; i < series.Length; i++)
                {
                    char inspectedValue = series[i];
                    if (GridMovement.R2XValue > GridMovement.globalXValue)
                    {
                        GridMovement.R2XValue = GridMovement.globalXValue;
                        break;
                    }
                    else if (GridMovement.R2YValue > GridMovement.globalYValue)
                    {
                        GridMovement.R2YValue = GridMovement.globalYValue;
                        break;
                    }
                    else if (inspectedValue == 'M' && GridMovement.R2Direction == 'N')
                    {
                        GridMovement.R2YValue = GridMovement.R2YValue + 1;
                    }
                    else if (inspectedValue == 'M' && GridMovement.R2Direction == 'S')
                    {
                        GridMovement.R2YValue = GridMovement.R2YValue - 1;
                    }
                    else if (inspectedValue == 'M' && GridMovement.R2Direction == 'L')
                    {
                        GridMovement.R2XValue = GridMovement.R2XValue + 1;
                    }
                    else if (inspectedValue == 'M' && GridMovement.R2Direction == 'O')
                    {
                        GridMovement.R2XValue = GridMovement.R2XValue - 1;
                    }
                    else if (inspectedValue == 'E' && GridMovement.R2Direction == 'N')
                    {
                        GridMovement.R2Direction = 'O';
                    }
                    else if (inspectedValue == 'E' && GridMovement.R2Direction == 'O')
                    {
                        GridMovement.R2Direction = 'S';
                    }
                    else if (inspectedValue == 'E' && GridMovement.R2Direction == 'S')
                    {
                        GridMovement.R2Direction = 'L';
                    }
                    else if (inspectedValue == 'E' && GridMovement.R2Direction == 'L')
                    {
                        GridMovement.R2Direction = 'N';
                    }
                    else if (inspectedValue == 'D' && GridMovement.R2Direction == 'N')
                    {
                        GridMovement.R2Direction = 'L';
                    }
                    else if (inspectedValue == 'D' && GridMovement.R2Direction == 'L')
                    {
                        GridMovement.R2Direction = 'S';
                    }
                    else if (inspectedValue == 'D' && GridMovement.R2Direction == 'S')
                    {
                        GridMovement.R2Direction = 'O';
                    }
                    else if (inspectedValue == 'D' && GridMovement.R2Direction == 'O')
                    {
                        GridMovement.R2Direction = 'N';
                    }

                    
                }
                GridMovement.R2Active = "Inativo";
                GridMovement.ExpeditionGraph(0, 0);
            }
        }
    }
}
