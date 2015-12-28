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

public class Customer
{	

	
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
 
	private bool Valid()
	{
		return true;
	}
	public bool Save()
	{
		Valid();
		DataSetup();
		return true;
	}
	private bool DataSetup()
	{
		return true;
	}
}

public class RetailCustomer: Customer
{
	public string CreditCard { get; set; }
	public string RetailIdentifier { get; set; }
}

public class OnlineClient: Customer
{
	public string OnlineIdentifier { get; set; }
	public string WebHistory {get;set;}

}