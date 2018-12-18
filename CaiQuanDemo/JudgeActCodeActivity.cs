using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace CaiQuanDemo
{

    public sealed class JudgeActCodeActivity : CodeActivity
    {
        // Define an activity input argument of type string
        //public InArgument<string> Text { get; set; }

        // 定义一个字符串类型的活动输入参数
        public InArgument<string> InputAct { get; set; }
        public OutArgument<int> Result { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            //string text = context.GetValue(this.Text);


            // 获取 Text 输入参数的运行时值
            string text = context.GetValue(InputAct);
            int result;
            switch (text)
            {
                case "stone": result = 0; break;
                case "jiandao": result = 1; break;
                case "bu": result = 2; break;
                default: result = -1; break;
            }
            context.SetValue(Result, result);

        }
    }
}
