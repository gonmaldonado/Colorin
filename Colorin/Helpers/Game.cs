using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colorin.Helpers
{
   

    public static class Game
    {
        static string[] Colores = { "Rojo", "Azul", "Verde", "Violeta", "Amarillo", "Gris", "Negro", "Blanco", "Naranja" };
        static string[] Colors = { "Red", "blue", "Green", "Violet", "Yellow", "Gray", "Black", "White", "Orange" };

        public static bool Validation(int objective, int selection)
        {
            bool result = false;
           if (objective == selection){ result = true; }
            return result;
        }
        public static int Score(int puntaje, bool accion)
        {
            int score = 0;
            if (accion) { score = puntaje + 100; }
            return score;
        }
        public static int GetNumber()
        {
            var randomNumber = new Random().Next(0,9);
            return randomNumber;
        }
        public static string GetColor (int Objetivo, int Level)
        {
            string resultado = Colores[Objetivo];
            var randomColor = new Random().Next(0,99);
            if (Level == 2) { resultado = Colors[Objetivo]; }
            if (Level == 3) { if ((randomColor % 2) == 0) { resultado = Colores[Objetivo]; } else { resultado = Colors[Objetivo]; } }
            return resultado;
        }
    }
}
