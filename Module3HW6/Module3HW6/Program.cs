using System;
using System.Threading.Tasks;

namespace Module3HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new MessageBox();
            var tsk = new TaskCompletionSource();

            message.Action += (state) =>
            {
                // var msg = state != State.Ok ? "Ok - операция была подтверджена" : "Cancel - операция была отклонена";
                // Console.WriteLine(msg);
                CloseWindow(state);

                tsk.SetResult();
            };

            message.OpenAsync();
            tsk.Task.GetAwaiter().GetResult();
        }

        private static void CloseWindow(State state)
        {
            if (state == State.Ok)
            {
                Console.WriteLine("Ok - операция была подтверджена");
            }
            else
            {
                Console.WriteLine("Cancel - операция была отклонена");
            }
        }
    }
}
