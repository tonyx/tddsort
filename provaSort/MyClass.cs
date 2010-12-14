/*
 * Created by SharpDevelop.
 * User: Tonino
 * Date: 14/12/2010
 * Time: 01:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

using System.Linq;



namespace provaSort
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public static class MyClass
	{
		public static List<int> MySort(this List<int> myArray)
		{
			List<int> toReturn = myArray.ToList();
			if (toReturn.Count<2)
				return toReturn;			
			int lesser = toReturn.Min();
			toReturn.Remove(lesser);
			return (new List<int>(){lesser}).Concat(toReturn.MySort()).ToList();
		}
		
		public static bool IsSorted(this List<int> myArray)
		{
			if (myArray.Count<=1)
				return true;
			if (myArray.ElementAt(0)<myArray.ElementAt(1)&&myArray.Tail().IsSorted())
				return true;
			return false;			
		}
		
		public static List<int> Tail(this List<int> myArray)
		{
			return (myArray.Skip(1).ToList());
		}
		
	}
}