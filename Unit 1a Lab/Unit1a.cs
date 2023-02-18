using System;
					
public class Program
{
	public Fishing salmon;
	 
	public void Main()
	{
	
		salmon = new Fishing();
		salmon.fishCount += 1;
		Console.WriteLine(salmon.fishType + " caught today equals " + salmon.fishCount + ".");
	}
}

public class Fishing {
	public int fishCount = 5;
	public string fishType = "Salmon";
	
}