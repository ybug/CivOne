﻿// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using CivOne.Interfaces;

namespace CivOne.Civilizations
{
	internal class Greek : ICivilization
	{
		public string Name
		{
			get { return "Greek"; }
		}

		public string NamePlural
		{
			get { return "Greeks"; }
		}

		public string LeaderName
		{
			get { return "Alexander"; }
		}

		public byte PreferredPlayerNumber
		{
			get { return 6; }
		}
	}
}