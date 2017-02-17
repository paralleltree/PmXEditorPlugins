using System;
using System.Collections.Generic;
using System.Linq;

using PEPlugin;

namespace WeightedOffsetBlend
{
    public class Plugin : PEPluginClass
    {
        private static MainForm FormInstance { get; set; }

        public override string Name
        {
            get { return "重み付きオフセット付加"; }
        }

        public override IPEPluginOption Option
        {
            get
            {
                return new PEPluginOption(bootup: true);
            }
        }

        public override void Run(IPERunArgs args)
        {
            if (args.IsBootup)
            {
                FormInstance = new MainForm(args.Host);
                FormInstance.Visible = false;
                FormInstance.Show();
                return;
            }

            FormInstance.Visible = true;
            FormInstance.BringToFront();
        }
    }
}
