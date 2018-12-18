using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace financeDemo
{

    public sealed class InputMoneyActivity : CodeActivity
    {
        // Define an activity input argument of type string
        //public InArgument<string> Text { get; set; }

        //定义一个Int类型的输出参数
        public OutArgument<int> Money { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            //string text = context.GetValue(this.Text);

            int money;
            var v = Console.ReadLine();
            int.TryParse(v, out money);
            context.SetValue(Money, money);
        }
    }
}
