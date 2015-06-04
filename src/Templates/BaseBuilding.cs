// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using CivOne.GFX;
using CivOne.Interfaces;

namespace CivOne.Templates
{
	internal abstract class BaseBuilding : IBuilding
	{
		public virtual Picture Icon
		{
			get
			{
				return null;
			}
		}
		public string Name { get; protected set; }
		public IAdvance RequiredTech { get; protected set; }
		public byte Price { get; protected set; }
		public byte Maintainance { get; protected set; }
		
		protected BaseBuilding(byte price = 1, byte maintainance = 0)
		{
			Price = price;
			Maintainance = maintainance;
		}
	}
}