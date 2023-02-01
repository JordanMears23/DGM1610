using System;
					
public class Program
{
	public static void Main()
	{
		weapon[] weaponType = {new weapon(), new weapon(), new weapon(), new weapon()};
		weaponType[1].weaponName = "Bō";
		weaponType[2].weaponName = "Sai";
		weaponType[3].weaponName = "Nunchaku";
		
		for(var i=0; i<weaponType.Length; i++){
			weaponType[i].powerLevel = 1;
			
		}
		
		foreach(var type in weaponType){
			Console.WriteLine(type.weaponName);
			Console.WriteLine(type.powerLevel);
		}
		
	}
}

public class weapon{
	public string weaponName = "Katana";
	public int powerLevel = 1;
}
