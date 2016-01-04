using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.TUTS_AsyncAndAwait
{
    public static class AsyncAndAwait
    {
        public static void AsyncAndAwaitCaller()
        {
            Task mytask = Task.Run(() =>
            {
                Form1 form = new Form1();
                form.ShowDialog();
            });
        }
    }
}
