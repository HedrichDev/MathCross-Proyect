using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MathCross.Models;
using MathCross.Utils;

namespace MathCross
{
    class Program
    {
        private static GameState gameState;
        private static Player player;
        private static bool isRunning = true;

        static void Main(string[] args)
        {
            // Detectar si estamos en Windows para modo gráfico
#if WINDOWS
            try
            {
                // En Windows, iniciar la aplicación gráfica
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
                
                // Inicialización básica
                player = new Player("Player");
                gameState = new GameState();
                gameState.CurrentPlayer = player;
                
                // Iniciar la aplicación de Windows Forms
                System.Windows.Forms.Application.Run(new MathCross.Forms.MainForm());
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al iniciar modo gráfico: {ex.Message}");
                Console.WriteLine("Iniciando modo consola como alternativa...");
            }
#endif

            // Si no estamos en Windows o hubo un error, ejecutar en modo consola
            Console.Title = "Math Cross Puzzle Game";
            
            Initialize();
