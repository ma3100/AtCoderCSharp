using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderStudy._4月
{
	public class FiveDishes
	{
		public class Dish
		{
			public int Time { get; set; }
			public int Amari { get; set; }
		}

		public void Do()
		{
			var array = new List<Dish>();
			for (int i = 0; i < 5; i++)
			{
				var time = int.Parse(Console.ReadLine());
				array.Add(new Dish() { Time = time, Amari = time % 10 });
			}

			array.OrderByDescending(x => x.Amari);


			var answer = 0; 
			foreach(var dish in array)
			{
				answer += dish.Time;
				if(dish.Amari != 0)
				{
					answer += 10 - dish.Amari;
				}
			}

			Console.WriteLine(answer);
		}
	}
}

