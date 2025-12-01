using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
	public class StringKey : IComparable<StringKey>
	{	
		public String KeyName { get; }

		public StringKey(String keyName) 
		{
			KeyName = keyName;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;

			if (obj.GetType() != this.GetType())
			{
				return false;
			}

			StringKey objAsItem = (StringKey)obj;

			if (objAsItem.KeyName != this.KeyName)
				return false;

			return true;
		}

		public int CompareTo(StringKey other)
		{
			if (other == null)
				return 1;
			else
			{
				return this.KeyName.CompareTo(other.KeyName);
			}
		}

		public override String ToString()
		{
			return $"KeyName: {KeyName} HashCode: {GetHashCode()}";
		}

		public override int GetHashCode()
		{
			return Math.Abs(GetHashCodeRecursive(0));
		}

		private int GetHashCodeRecursive(int index)
		{
			if (index >= KeyName.Length)
				return 0;

			int currentChar = KeyName[index];
			int hashSegment = GetHashCodeRecursive(index + 1);

			return currentChar + (31 * hashSegment);
		}
	}
}
