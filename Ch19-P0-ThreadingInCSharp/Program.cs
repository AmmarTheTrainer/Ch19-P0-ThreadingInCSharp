using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ch19_P0_ThreadingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExtractExecutingThread();
            //ExtractAppDomainHostingThread();
            ExtractCurrentThreadContext();
            Console.ReadKey();
        }

        static void ExtractCurrentThreadContext()
        {
            // Obtain the context under which the
            // current thread is operating.
            Context ctx = Thread.CurrentContext;
            Console.WriteLine(ctx.ContextID);
        }

        static void ExtractAppDomainHostingThread()
        {
            // Obtain the AppDomain hosting the current thread.
            AppDomain ad = Thread.GetDomain();
            Console.WriteLine(ad.BaseDirectory);
            Console.WriteLine(ad.Id);
            Console.WriteLine(ad.FriendlyName);
        }
        static void ExtractExecutingThread()
        {
            // Get the thread currently
            // executing this method.
            Thread currThread = Thread.CurrentThread;

            Console.WriteLine("Thread Name : {0}",currThread.Name);
            Console.WriteLine("Thread ID : {0}",currThread.ManagedThreadId);
        }
    }
}
