using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPractice
{
    class Widget1Decorator : WidgetAbstract
    {
        WidgetInterface widgetInterface;
        public Widget1Decorator(WidgetInterface widgetInterface) : base(widgetInterface)
        {
            this.widgetInterface = widgetInterface;
        }

        public override string MakeWidget()
        {
            return widgetInterface.MakeWidget()+" Adding pie chart as widget";
        }
    }
}
