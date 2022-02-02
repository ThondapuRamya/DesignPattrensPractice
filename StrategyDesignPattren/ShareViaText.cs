using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattren
{
    class ShareViaText : SharePhotosInterface
    {
        public string SharePhotos()
        {
            return "Share photos via text";
        }
    }
}
