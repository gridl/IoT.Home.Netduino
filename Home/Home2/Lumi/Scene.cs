using System;
using System.Collections;
using System.Text;

namespace VLumi
{
    public class Scene
    {
        /// <summary>
        /// Scene with Lumis
        /// </summary>
        public Scene(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

    }
}
