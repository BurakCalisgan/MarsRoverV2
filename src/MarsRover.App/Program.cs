using MarsRover.Business.Concrete;
using MarsRover.Business.Enums;
using System;
using System.Linq;

namespace MarsRover.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plateau size :");
            var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Rover position :");
            var startPositions = Console.ReadLine().Trim().Split(' ');
            Position position = new();

            if (startPositions.Count() == 3)
            {
                position.X = Convert.ToInt32(startPositions[0]);
                position.Y = Convert.ToInt32(startPositions[1]);
                position.Direction = (Directions)Enum.Parse(typeof(Directions), startPositions[2]);
            }

            Console.WriteLine("Rover command :");
            var moves = Console.ReadLine().ToUpper();

            try
            {
                position.StartMoving(maxPoints, moves);
                Console.WriteLine("Expected Output:");
                Console.WriteLine($"{position.X} {position.Y} {position.Direction}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
