﻿using Glimpse.Core.Extensibility;

namespace Glimpse.Core.Handler
{ 
    [GlimpseHandler]
    public class Sprite : ImageHandlerBase
    {
        public override string ResourceName
        {
            get { return "glimpseSprite"; }
        }

        protected override string ContentType
        {
            get { return "image/png"; }
        }
    } 
}