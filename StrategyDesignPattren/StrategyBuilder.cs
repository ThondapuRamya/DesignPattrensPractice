using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattren
{
    class StrategyBuilder : SharePhotosInterface
    {
        SharePhotosInterface sharePhotosInterface;

        public StrategyBuilder(SharePhotosInterface sharePhotosInterface)
        {
            this.sharePhotosInterface = sharePhotosInterface;
        }

        public string SharePhotos()
        {
            return sharePhotosInterface.SharePhotos();
        }
    }
}
