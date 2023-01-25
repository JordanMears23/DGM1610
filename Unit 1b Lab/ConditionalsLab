using System;
					
public class Program
{
	public Operations myOperator;
	public Password passwordStrength;
	
	public void Main()
	{
		passwordStrength = new Password();
		passwordStrength.firmness = Password.Durability.Weak;
		passwordStrength.CheckPasswordStrength();
		myOperator = new Operations();
		
		
		Console.WriteLine("Welcome");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
		myOperator.CheckPassword("SevenOF9");
		myOperator.CheckPassword("OU812");
		myOperator.PasswordExpired(46);
		myOperator.PasswordExpired(90);
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the first greater.");
		} else {
			Console.WriteLine("False, the second is greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "OU812") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");	
		}
	}
	
	public void PasswordExpired (int expired) {
		if (expired >= 90) {
			Console.WriteLine("Password Update Required Now");
		}
		else if (expired >= 45) {
			Console.WriteLine("Password Update Required Soon");
		}
		else {
			Console.WriteLine("Password Update Not Required");
		}
	

	}
}
public class Password {
	
		public enum Durability {
			Strong,
			Good,
			Weak
		}
		
		public Durability firmness = Durability.Strong;
	
		public void CheckPasswordStrength (){
		switch (firmness){
			case Durability.Strong: 
				Console.WriteLine("Strong");
				break;
			case Durability.Good: 
				Console.WriteLine("Good");
				break;
			case Durability.Weak: 
				Console.WriteLine("Weak");
				break;
			}
		}
	}
