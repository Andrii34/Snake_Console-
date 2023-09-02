using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {


           // Console.SetBufferSize(80, 25);
            Walls walls = new Walls(80,25);
            walls.Draw();
            Point point = new Point(4, 5, 's');
            Snake snake = new Snake(point, 4, Direction.RIGHT);
            snake.Drow();
            FoodCreator foodCreator= new FoodCreator(80,25,'@');
            Point food = foodCreator.CreateFood();
            food.Draw();
           
            while(true)
            {
                    if(walls.IsHith(snake)|| snake.IsHitTail())
                    {
                        break;
                    }
                if (snake.Eat(food))
                {
                    food=foodCreator.CreateFood();
                    food.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    
                }
                Thread.Sleep(100);
                snake.Move();
            }
            


           


        }
        
    }
}
