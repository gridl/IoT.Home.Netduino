using System;
using Microsoft.SPOT;

namespace HomeStation.Light
{
    public class Lumi
    {
        private string nome;
        private InfraredLight infrared_light;

        public Lumi(string nome, InfraredLight infraredLight)
        {
            this.nome = nome;
            this.infrared_light = infraredLight;
        }

        /// <summary>
        /// Send raw IR command
        /// </summary>
        /// <param name="command">Command to be sent</param>
        public void Send(int command)
        {
            this.infrared_light.Send(command);
        }
    }
}
