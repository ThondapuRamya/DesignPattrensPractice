using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattren
{
    class ShareViaEmail : SharePhotosInterface
    {
        public string SharePhotos()
        {
            return "Share photos via email";
        }
    }
}
