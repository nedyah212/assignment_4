using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
	public class HashMap<K, V>
	{
		public Entry<K, V> [] Table { get; set;}

		int Size { get; set;}
		int Placeholders { get; set;}

		const int CAPACITY = 11;
		const double LOAD_FACTOR = 0.75;

		int InitialCapacity;
		double LoadFactor;

		public HashMap()
		{
			InitialCapacity = CAPACITY;
			LoadFactor = LOAD_FACTOR;
		}

		public HashMap(int initialCapacity)
		{ 
			InitialCapacity = initialCapacity;
			LoadFactor = LOAD_FACTOR;
		}

		public HashMap(double loadFactor)
		{
			InitialCapacity = CAPACITY;
			LoadFactor = loadFactor;
		}
	}
}
