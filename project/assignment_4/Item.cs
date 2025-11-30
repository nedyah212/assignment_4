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
			bool result = true;
			try
			{
				if (obj == null)
					throw new ArgumentNullException("The object cannot be null");

				if (obj.GetType() != this.GetType())
				{
					throw new ArgumentException("The object has to be an item");	
				}

				Item objAsItem = (Item)obj;
				
				if (objAsItem.Name != this.Name)
					result = false;
				if (objAsItem.GoldPieces != this.GoldPieces)
					result = false;
				if (objAsItem.Weight != this.Weight)
					result = false;
			}
			catch (ArgumentNullException)
			{
				result = false;
			}
			
			catch (ArgumentException)
			{
				result = false;
			}

			return result;
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
