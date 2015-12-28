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
		
		var customer = new Customer()
		{ FirstName = "Derek",LastName="Kowalski",Email="Something"};
		
		// customer.Valid();
		// customer.DataSetup();
		// customer.Save();
		
		customer.Save();
		Debug.WriteLine("Bye World!");
		

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