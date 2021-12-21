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
        private Random _random = new Random();
        public Action<State> Action { get; set; }
        public async void OpenAsync()
        {
            Console.WriteLine("Окно открыто");
            await Task.Delay(3000);
            Console.WriteLine("Окно было закрыто пользователем");

            var randomState = _random.Next(0, 1);

            if (randomState == 0)
            {
                Action.Invoke(State.Ok);
            }
            else
            {
                Action.Invoke(State.Cancel);
            }
        }
    }
}
