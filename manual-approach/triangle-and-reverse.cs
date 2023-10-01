// csc triangle-and-reverse.cs
// dotnet build file1.cs file2.cs file3.cs
// dotnet run
// dotnet publish -c Release -r win-x64
// dotnet publish -c Release -r win10-x64 --self-contained

using System;

namespace everything
{
    internal class Program {
		private static void hypotenuse(in int a, in int b, out double c){
			c = Math.Sqrt(a*a + b*b);
		}
		public static void triangle(){
			Console.WriteLine("Input int variable a:");
			int a = Convert.ToInt32( Console.ReadLine() );
			Console.WriteLine("Input int variable b:");
			int b = Convert.ToInt32( Console.ReadLine() );
		
			double c;
			hypotenuse(in a, in b, out c);
			Console.WriteLine(
				"Side a = {0}, side b = {1}, and the hypotenuse c = {2}",
				a,b,c
			);
			return;
		}
		
		private static void create_array(in int a, in int b, out int[] c){
			c = new int[b-a+1];
			int j = a;
			for(int i = 0; i < c.Length ; i++){
				c[i] = j;
				j++;
			}
		}
		private static void reverse_array(in int[] c, out int[] d){
			int len = c.Length;
			d = new int[len];
			foreach( int number in c){
				d[len-1] = number;
				len--;
			}
		}
		public static void reverse(){
			Console.WriteLine("Input lover bound number:");
			int a = Convert.ToInt32( Console.ReadLine() );
			Console.WriteLine("Input higher bound number:");
			int b = Convert.ToInt32( Console.ReadLine() );
			if(b>a){
				create_array(in a, in b, out int[] c);
				reverse_array(in c, out d);
			}else{
				Console.WriteLine("b value had to be larger");
			}
		}
	}
	
	public static void Main(string[] args){
		triangle();
		reverse();
	}
}
