using System;
using System.Diagnostics;
using System.Windows.Forms;

class Script
{
    [STAThread]
    static public void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Debug.WriteLine("Hello World!");
    }
}
//Nie możemy utworzyć obiektu klasy typu abstract
public abstract class Customer
{		
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
 
	private bool Valid()
	{
		return true;
	}
	public virtual bool Save()
	{
		Valid();
		DataSetup();
		return true;
	}
	private bool DataSetup()
	{
		return true;
	}
	//'RetailCustomer' must implement inherited abstract member 'DoSomething()'
	public abstract string DoSomething(); 
}

public sealed class RetailCustomer: Customer
{
	public string CreditCard { get; set; }
	public string RetailIdentifier { get; set; }
	
	public override bool Save()
	{
		return true;
	}
	
	public override string DoSomething() { return "a"; }
}

public class OnlineClient: Customer
{
	public string OnlineIdentifier { get; set; }
	public string WebHistory {get;set;}
	
	//cannot override inherited member 'Customer.Save()' because it is not marked virtual, abstract, or override
	public override bool Save()
	{
		return true;
	}
	
	public override string DoSomething() { return "a"; }

}