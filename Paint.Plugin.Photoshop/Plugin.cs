using Paint.Contracts;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System;

namespace Paint.Plugin.Photoshop
{
    [Export(typeof(IPlugin))]
    public class Plugin : BasePlugin, IPlugin
    {
        public Plugin()
            : base("PSD")
        {
            Console.WriteLine("ctor_{0}", Name);
        }

        public override IFileType[] FileTypes
        {
            get
            {
                var l = new List<IFileType> { new FileType() };
                return l.ToArray();
            }
        }
    }
}