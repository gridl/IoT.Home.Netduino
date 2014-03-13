using System;
using Microsoft.SPOT;

using HomeStation.InfraRed.Encoder;

namespace HomeStation.Light
{
    public class InfraredLight
    {
        private string model;
        private InfraredCodecNEC infrared_codec;
        private int address;
        
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="model">Infrared Light device</param>
        /// <param name="codec">Codec for device</param>
        /// <param name="address">Device address</param>
        public InfraredLight(string model, InfraredCodecNEC codec, int address)
        {
            this.model = model;
            this.infrared_codec = codec;
            this.address = address;
        }

        /// <summary>
        /// Codec for infrared light
        /// </summary>
        public InfraredCodecNEC InfraredCodec { get { return this.infrared_codec; } }

        /// <summary>
        /// Send IR command
        /// </summary>
        /// <param name="command">Command to be sent</param>
        public void Send(int command)
        {
            infrared_codec.Send(address, command);
        }
    }
}
