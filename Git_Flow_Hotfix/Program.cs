using System;

namespace Git_Flow_Hotfix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("¡Hola, mundo!");
            
            Player personaje = new Player
            {
                Name = "Guerrero",
                Health = 100, // 100 
                Attack = 50,
                Defense = 30,
                Level = 1
            };
            // Personaje
            Console.WriteLine($"Personaje creado: {personaje.Name} y {personaje.Level}");
            
        }
    }

}
    public class Player
    {
        public string? Name {get;set;}
        public int Health {get; set;}
        public int Attack {get; set;}
        public int Defense{get;set;}
        public int Level {get; set;}

    }