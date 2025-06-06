﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiAP
{
    public class Text
    {
        public static void MenuText()
        {
            Console.Clear();
            Console.WriteLine("---------------------");
            Console.WriteLine("Tupiniquim I");
            Console.WriteLine("---------------------\n\n");
            Console.WriteLine("1.Expedição\n2.Sair");
        }

        public static void GridCreateMsg()
        {
            Console.Clear();
            Console.WriteLine("Insira O Tamanho do Grid (x,y)");
        }
        
        
        public static void GridMaxValues()
        {
            Console.Clear();
            Console.WriteLine($"Tamanho do Grid: {GridMovement.globalXValue},{GridMovement.globalYValue}");
        }
        
        
        public static void RobotText(int code)
        {
            if (code == 1)
            {
                Console.WriteLine("\n------------------");
                Console.WriteLine("Robô 1:");
                Console.WriteLine($"Posição Atual: {GridMovement.R1XValue}, {GridMovement.R1YValue}"); 
                Console.WriteLine($"Virado Para: {GridMovement.R1Direction}"); 
                Console.WriteLine($"Estado: {GridMovement.R1Active}"); 
                Console.WriteLine("------------------\n");
            } else if (code == 2)
            {
                Console.WriteLine("\n------------------");
                Console.WriteLine("Robô 2:");
                Console.WriteLine($"Posição Atual: {GridMovement.R2XValue}, {GridMovement.R2YValue}"); 
                Console.WriteLine($"Virado Para: {GridMovement.R2Direction}"); 
                Console.WriteLine($"Estado: {GridMovement.R2Active}"); 
                Console.WriteLine("------------------\n");
            }
        }

        public static void ShowInfo()
        {
            GridMaxValues();
            RobotText(1);
            RobotText(2);
        }


        public static void EnquireString1()
        {
            Console.WriteLine("Insira uma String de Comando (x,y,direcão):");

        }

        public static void EnquireString2()
        {
            Console.WriteLine("Insira a Próxima String de Comando (e,d,m,e,d,m...):");
        }

    
        
        public static void FinalEnqString()
        {
            Console.WriteLine("\nPrograma Finalizado, deseja reiniciar? (y/n)");
        }

        public static void GridError()
        {
            Console.WriteLine("Erro. Valor Inicial Exede um o mais parâmetros do grid, posição ajustada automaticamente. Pressione Enter para Continuar.");
        }
        public static void ExitMsg()
        {
            Console.WriteLine("Saindo do Programa...");
        }
    
    
    }
}
