using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module3HW6
{
    public class MessageBox
    {
        public async void OpenAsync()
        {
            Console.WriteLine("Окно открыто");
            Thread.Sleep(3000);
        }
    }
}
