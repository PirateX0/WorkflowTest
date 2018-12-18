using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace WorkflowConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            Workflow1 workflow1 = new Workflow1();
            workflow1.num = new InArgument<int>() { Expression=-1};
            WorkflowInvoker.Invoke(workflow1);
            Console.ReadKey();
        }
    }
}
