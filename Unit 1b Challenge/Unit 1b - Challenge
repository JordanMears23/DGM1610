using System;
					
public class Program
{
	public PizzaOptions myOptions;
	public PrepTime cookTime;
	
	public void Main()
	{
		myOptions = new PizzaOptions();
		myOptions.CheckPizzaType("Supreme");
		cookTime = new PrepTime();
		cookTime.TotalTime = PrepTime.Time.Twenty;
		cookTime.CheckPrepTime();
	
	}
}

public class PizzaOptions{
	
	
	public void CheckPizzaType (string pizza){
		if (pizza == "Cheese") {
		Console.WriteLine("Pizza Type is Cheese");
		}
		else if (pizza == "Pepperoni") {
		Console.WriteLine("Pizza Type is Pepperoni");
		} 
		else if (pizza == "Supreme") {
		Console.WriteLine("Pizza Type is Supreme");
		}
		else {
		Console.WriteLine("Pizza Type is Not Available");
		}
	}
}

public class PrepTime {
	
	public enum Time{
		Ten,
		Fifteen, 
		Twenty	
	}
	
	public Time TotalTime = Time.Fifteen;
	
	public void CheckPrepTime (){
	
		switch (TotalTime){
			case Time.Ten:
				Console.WriteLine("Cook Time is 10 Minutes");
				break;
		}
		switch (TotalTime){
			case Time.Fifteen:
				Console.WriteLine("Cook Time is 15 Minutes");
				break;
		}
		switch (TotalTime){
			case Time.Twenty:
				Console.WriteLine("Cook Time is 20 Minutes");
				break;		
		}	
	}
}