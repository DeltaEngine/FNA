using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

namespace TestXnaApp;

public class Program
{
	public static void Main(string[] args)
	{
		using (Game1 game = new Game1())
		{
			game.Run();
		}
	}
}
