using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using Task6;

namespace Task4.Properties
{
    public static class PushingCats
    {
        public static void Run()
        {
            Subject<Cat> subject = new Subject<Cat>();
            var subscription = subject.Subscribe(
                                     x => Console.WriteLine("Value published: {0}", x),
                                     () => Console.WriteLine("Sequence Completed."));
            /*subject.OnNext(1);

            subject.OnNext(2);
            */
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            subject.OnCompleted();
            subscription.Dispose();
        }
    }
}
