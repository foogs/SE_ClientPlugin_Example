using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using Sandbox;
using VRage.Plugins;
using VRage.Collections;
using VRage.FileSystem;
using VRage.Utils;

namespace Example
{
    public class Plugin : IPlugin
    {
        public static Plugin PluginInstance;
        public static MySandboxGame se_instance;
        public void Init(object gameInstance)
        {
            se_instance = (MySandboxGame)gameInstance;
            PluginInstance = this;
            MyLog.Default.WriteLine("Example plugin loaded!");
        }
        public void Update()
        {

        }

        public void Dispose()
        {

            MyLog.Default.WriteLine("Example plugin unloaded!");
        }

    }
}
