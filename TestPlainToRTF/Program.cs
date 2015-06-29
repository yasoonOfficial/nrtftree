using Net.Sgoliver.NRtfTree.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TestPlainToRTF
{
    class Program
    {
        static void Main(string[] args)
        {
            RtfDocument doc = new RtfDocument(Encoding.Unicode);
            doc.AddText("Some note yo\n123\n\n133\nψυχή", new RtfCharFormat { Font = "Calibri", Size = 11 });
            Console.Write(doc.Rtf);
            Trace.Write(doc.Rtf);
            Console.In.Read();
        }
    }
}
