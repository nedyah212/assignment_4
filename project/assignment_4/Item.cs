using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
	public class Item : IComparable<Item>
	{
		public string Name;
		public int GoldPieces;
		public double Weight;

		public Item(string name, int goldPieces, double weight)
		{
			Name = name;
			GoldPieces = goldPieces;
			Weight = weight;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;

			if (obj.GetType() != this.GetType())
			{
				return false;	
			}

			Item objAsItem = (Item)obj;

			if (objAsItem.Name != this.Name || objAsItem.GoldPieces != this.GoldPieces ||
															objAsItem.Weight != this.Weight)
				return false;

			return true;
		}

		public int CompareTo(Item other)
		{
			if (other == null)
				return 1;
			else
			{
				return this.Name.CompareTo(other.Name);
			}
		}

		public override string ToString()
		{
			return $"{this.Name} is worth {this.GoldPieces}gp and weighs {this.Weight}kg";
		}
	}
}
