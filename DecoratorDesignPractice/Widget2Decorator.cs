using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPractice
{
    class Widget2Decorator : WidgetAbstract
    {
        WidgetInterface widgetInterface;

        public Widget2Decorator(WidgetInterface widgetInterface) : base(widgetInterface)
        {
            this.widgetInterface = widgetInterface;
        }

        public override string MakeWidget()
        {
            return widgetInterface.MakeWidget() + " Adding bar chart as widget";
        }
    }
}
