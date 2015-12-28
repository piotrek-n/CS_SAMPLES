
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SRP
{
	class Script
	{
		[STAThread]
		static public void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Debug.WriteLine("Hello World!");
		}
	}
	
	public class Invoice
	 {
		 public decimal Subtotal {get;set;}
		 public decimal TaxRate {get;set;}
		 
		 public decimal CalculateTax()
		 {
			 return Subtotal * TaxRate / 100;
		 }
		 
		 public decimal CalculateTotal()
		 {
			 return Subtotal + CalculateTax();
		 }
		 
	 }
	 
	 public class InvoicePrinter
	 {
		public void Print(Invoice invoice)
		 {
			 
		 } 
	 }
 
}