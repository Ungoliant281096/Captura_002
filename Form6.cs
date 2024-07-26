using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captura
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            textBox1.Text = ConfiguracionGlobal.GeneralPath;
        }

        private void distribuirRutas(string rutaCostosyContabilidad)
        {
            textBox1.Text = rutaCostosyContabilidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    ConfiguracionGlobal.GeneralPath = folderBrowserDialog.SelectedPath + "\\";
                    UpdateFileLine(ConfiguracionGlobal.GeneralPath);
                    distribuirRutas(ConfiguracionGlobal.GeneralPath);
                }
            }
        }
        public static void UpdateFileLine(string newContent)
        {
            if (File.Exists("C:/GconTA/Gcont.Arr"))
            {

                File.WriteAllText("C:/GconTA/Gcont.Arr", newContent);
            }
            else
            {
                throw new FileNotFoundException("File not found.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
