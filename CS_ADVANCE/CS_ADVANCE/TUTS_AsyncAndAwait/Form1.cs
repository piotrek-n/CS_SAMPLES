using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_ADVANCE.TUTS_AsyncAndAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = BigLongImportMethod("John"); // 1. Blokuje zablowanie UI
            //Task.Factory.StartNew(() => BigLongImportMethod("Sally")).ContinueWith(t => label1.Text = t.Result); //2. Cross-thread operation not valid: Control 'label1' accessed from a thread other than the thread it was created on
            //Task.Factory.StartNew(() => BigLongImportMethod("Sally")).ContinueWith(t => label1.Text = t.Result,TaskScheduler.FromCurrentSynchronizationContext()); // OK, dziala!!!
            CallBigLongImportMethodAsync();
            label1.Text = "Waiting...";
        }
        private async void CallBigLongImportMethodAsync()
        {
            var result = await BigLongImportMethodAsync("Sally"); //Wywolaj asynch metode Task. Await, czekaj na wykanie metody asychronicznej
            label1.Text = result;
        }
        private Task<string> BigLongImportMethodAsync(string name)
        {
            return Task.Factory.StartNew(() => BigLongImportMethod("Sally"));
        }
        private string BigLongImportMethod(string name)
        {
            Thread.Sleep(3000);
            return "Hello, " + name;
        }
    }
}
