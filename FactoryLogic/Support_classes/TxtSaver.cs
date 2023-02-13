using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
    public class TxtSaver : ISaver
    {
        private string FileName;

        public TxtSaver(string FileName)
        {
            this.FileName = FileName;
        }

        public void Save(string Data)
        {
            StreamWriter stream = new StreamWriter(Path.GetFullPath($@"{FileName}.txt"));

            stream.Write(Data);
            stream.Close();
        }
    }
}
