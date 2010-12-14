/*
 * Created by SharpDevelop.
 * User: Tonino
 * Date: 14/12/2010
 * Time: 01:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

namespace provaSort
{
	[TestFixture]
	public class QSortTest
	{
		
		[Test]
		public void ListOfSingleElementIsSorted() {
			List<int> oneElementList = new List<int>(){1};
			Assert.That(oneElementList.IsSorted(),Is.True);
		}
		
		[Test]
		public void ListOfTwoAscendingElementIsSorted() {
			List<int> twosortedElementList = new List<int>(){1,2};
			Assert.That(twosortedElementList.IsSorted(),Is.True);
		}		
		
				
		[Test]
		public void ListOfTwoDescendingElementIsNonSorted() {
			List<int> twosortedElementList = new List<int>(){2,1};
			Assert.That(twosortedElementList.IsSorted(),Is.False);
		}		
		
		[Test]
		public void AOneElementListSortedIsTheListItself() {
			List<int> oneElementList = new List<int>(){1};
			Assert.That(oneElementList.MySort(),Is.EqualTo(new List<int>(){1}));
		}
		
		
		[Test]
		public void ATwoElementListSortedIsTheListItself() {
			List<int> oneElementList = new List<int>(){1,2};
			Assert.That(oneElementList.MySort(),Is.EqualTo(new List<int>(){1,2}));
		}
		
		[Test]
		public void ATwoElementListDescendedSortedIsReverted() {
			List<int> oneElementList = new List<int>(){2,1};
			Assert.That(oneElementList.MySort(),Is.EqualTo(new List<int>(){1,2}));
		}
		
		[Test]
		public void TheFirstElementOfAListAfterSortingIsTheOneOfLessValue() {
			List<int> oneElementList = new List<int>(){2,3,7,8,4,1};
			Assert.That(oneElementList.MySort().ElementAt(0),Is.EqualTo(1));
		}		

		[Test]
		public void TheTailOfASortedListIsSorted() {
			List<int> oneElementList = new List<int>(){2,3,7,8,4,1};
			Assert.That(oneElementList.MySort().ElementAt(0),Is.EqualTo(1));
			Assert.That(oneElementList.MySort().Tail().IsSorted());
		}				
		
		[Test]
		public void SortAny() {
			List<int> anyElementList = new List<int>(){9,6,2,1,9,1};			
			Assert.That(anyElementList.MySort().ElementAt(0),Is.EqualTo(1));
			Assert.That(anyElementList.MySort().ElementAt(1),Is.EqualTo(1));
			Assert.That(anyElementList.MySort().ElementAt(2),Is.EqualTo(2));			
			Assert.That(anyElementList.MySort().ElementAt(3),Is.EqualTo(6));	
			Assert.That(anyElementList.MySort(),Is.EqualTo(new List<int>(){1,1,2,6,9,9}));
		}
		
		
				
		[Test]
		public void GetTail()
		{
			List<int> myList = new List<int>(){1,2,3};
			Assert.That(myList.Tail().ElementAt(0),Is.EqualTo(2));
		}
				
	}
}
