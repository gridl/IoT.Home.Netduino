using System;
using Microsoft.SPOT;

namespace HomeStation.Light
{
    class Led
    {
        public enum LedModel
        {
            /// <summary>
            /// Ledstripe Sylvania
            /// </summary>
            LedStripeSylvania = 1,
            /// <summary>
            /// Ledstripe DX
            /// </summary>
            LedStripeDX = 2
        }
        public enum CodecType
        {
            /// <summary>
            /// NEC
            /// </summary>
            NEC = 1,
            /// <summary>
            /// NEC Extended
            /// </summary>
            NECx = 2
        }
        
    }
}
