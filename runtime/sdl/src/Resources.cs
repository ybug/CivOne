// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using CivOne.Enums;
using CivOne.Graphics;
using CivOne.Graphics.ImageFormats;

namespace CivOne
{
	internal class Resources
	{
		private static Assembly CurrentAssembly { get; } = AppDomain.CurrentDomain.GetAssemblies().First(x => x.FullName.StartsWith("CivOne.SDL,"));

		private static Stream GetInternalResource(string name) => CurrentAssembly.GetManifestResourceStream($"CivOne.Resources.{name}");

		private static Stream HelpTextTxt => GetInternalResource("HelpText.txt");

		private static Stream WindowIcon => GetInternalResource("WindowIcon.gif");

		private static string GetResourceString(Stream resource)
		{
			using (Stream resourceStream = resource)
			{
				if (resourceStream == null) return null;

				using (StreamReader sr = new StreamReader(resourceStream))
				{
					return sr.ReadToEnd();
				}
			}
		}

		public static string BinPath => Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
		
		public static IBitmap GetWindowIcon()
		{
			using (Stream resourceStream = WindowIcon)
			using (MemoryStream ms = new MemoryStream())
			{
				resourceStream.CopyTo(ms);
				using (GifFile gifFile = new GifFile(ms.ToArray()))
				{
					return gifFile.GetBitmap();
				}
			}
		}
		
		public static string HelpText => GetResourceString(HelpTextTxt);
	}
}