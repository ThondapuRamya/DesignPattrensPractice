using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPractice
{
    class WidgetConcrete : WidgetInterface
    {
        public string MakeWidget()
        {
            return "Creating concrete widget";
        }
    }
}
