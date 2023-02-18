using System;
					
public class Program
{
	public void Main()
	{
		string[] NintendoSystem = {"NES", "SNES", "N64", "GameCube", "Wii", "Wii U", "Switch"};

		for(var i = 0; i < NintendoSystem.Length; i++) {
			Console.WriteLine(i);
		}
		
		foreach(var console in NintendoSystem){
			Console.WriteLine(console);
		}
	}
}