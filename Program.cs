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
            Console.Title = "Math Cross Puzzle Game";
