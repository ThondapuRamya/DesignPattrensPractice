using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattren
{
    class ShareViaSocialMedia : SharePhotosInterface
    {
        public string SharePhotos()
        {
            return "Share photos via social media like twitter";
        }
    }
}
