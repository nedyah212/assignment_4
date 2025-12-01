using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
	public class Entry<K, V>
	{
		public K Key;
		public V Value;

		public Entry(K key, V value)
		{
			Key = key;
			Value = value;
		}
	}
}
