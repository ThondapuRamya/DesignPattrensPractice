using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPractice
{
    class WidgetAbstract : WidgetInterface
    {
        WidgetInterface widgetInterface;

        public WidgetAbstract(WidgetInterface widgetInterface)
        {
            this.widgetInterface = widgetInterface;
        }
        public virtual string MakeWidget()
        {
            return widgetInterface.MakeWidget();
        }
    }
}
