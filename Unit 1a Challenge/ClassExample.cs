using System;
					
public class ClassWithFunctions
{
	public ClassWithVariables personFeatures;
		
	public void Main()
	{
		personFeatures = new ClassWithVariables();
		
		personFeatures.age = 42;
		personFeatures.userName = "Bob";
		personFeatures.height = 71;
		personFeatures.weight = 182.1F;
			
		Console.WriteLine( personFeatures.userName + " is " + personFeatures.age + " years old, weighs " + personFeatures.weight + " pounds, and is " + personFeatures.height + " inches tall.");
	}
}

public class ClassWithVariables
{
	public int height;
	public string userName; 
	public int age;
	public float weight;
}