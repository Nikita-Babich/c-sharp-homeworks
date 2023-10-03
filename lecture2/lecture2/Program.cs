using System;

namespace homework2
{
    internal class Program {
		
		public class Product{
			private string name;
			private double price;
			private int amount;
			
			public Student1(string k, double l, int m) //public konstruktor
			{
				name = k;
				price = l;
				amount = m;
			}
			public int Name { get => name; set => name = value; }
			public int Price { get => price; set => price = value; }
			public int Amount { get => amount; set => amount = Math.Max(value,0); }
			
			public void Print(){
				Console.WriteLine($"The product is named {name}, it costs {price} and there are {amount} entities.");
			}
			
			public Product FromLine(string info){
				string[] arguments = info.Split(' ');
				return Student1(arguments[0], double.Parse(arguments[1]), Convert.ToInt32(arguments[2]));
			}
			
		}
		
		public class Database{
			private Product[] list;
			
			public void ReadFromFile(string filename){
				using (StreamReader read = new StreamReader(filename))
				{
					int dataset_size = Convert.ToInt32( read.ReadLine() );
				}
			}
			
		}
		public static void Main(string[] args){
			
		}
	}
