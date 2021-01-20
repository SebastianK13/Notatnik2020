using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersOperations.IOMethods
{
    public class UsersMethods
    {
        public string fileText;
        public string fileName;
        public string savedFileName;
        private Stream fileStreamSave;

        public void WczytajPlikTekstowy()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "text file (*.txt)|*.txt";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = fileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileText = reader.ReadToEnd();
                    }
                    fileName = Path.GetFileName(fileDialog.FileName);
                }
            }

        }
        public void ZapiszPlikTekstowy(string content)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            fileDialog.Filter = "text file (*.txt)|*.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStreamSave = fileDialog.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(fileStreamSave))
                    {
                        writer.Write(content);
                    }

                    fileStreamSave.Close();
                    savedFileName = Path.GetFileName(fileDialog.FileName);
                }
            }
        }
    }
}
