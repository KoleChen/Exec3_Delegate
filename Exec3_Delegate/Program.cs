using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> testnumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //先創建一個List裡放1~10
			Func<int, bool> Even = n => n % 2 == 0; //如果是偶數傳回True
			List<int> EvenNumbers = GetEvenItems(testnumbers, Even); //再創一個List 裡面放GetEvenItems裡return的東西

			foreach (int i in EvenNumbers)
			{
				Console.WriteLine(i);
			}
		}

		static List<int> GetEvenItems(List<int> num,Func<int,bool>func)
		{
			var result = new List<int>();//創一個空的List叫result
			foreach(int item in num) //把上面叫testnumbers的List裡的1~10放進來
			{
				if(func(item)==true) //如果是true(偶數)
				{
					result.Add(item); //把是偶數的數字塞進result裡面
				}
			}
			return result;
		}
	}
}
