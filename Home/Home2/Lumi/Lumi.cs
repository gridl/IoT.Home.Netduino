using System;
using System.Collections;
using System.Text;

namespace VLumi
{
    public class Lumi
    {
        /// <summary>
        /// Luminary
        /// </summary>
        public Lumi(string nome, Light light)
        {
            this.Name = nome;
            this.Light = light;
        }

        /// <summary>
        /// Lumi name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Model of Infrared Light
        /// </summary>
        public Light Light { get; set; }

        /// <summary>
        /// Lumi Id
        /// </summary>
        public int Id
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
