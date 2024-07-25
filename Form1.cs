using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
//using static Captura.Class1;

namespace Captura
{
    public partial class Form1 : Form
    {
        private string filePath = "C:/GconTA/Gcont.Arr";
        private string fileContent;

        public int inicio;
        public int final;

        private Dictionary<int, string> cuentas;
        public Form1()
        {
            InitializeComponent();
            fileContent = ReadFileLine(filePath);

            ConfiguracionGlobal.GeneralPath = fileContent;

        }

        public static string ReadFileLine(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            else
            {
                throw new FileNotFoundException("File not found.");
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

        private void button14_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel3.Width < 250)
            {
                flowLayoutPanel3.Width = 250;
                buttonMenu.Width = 240;
                button1.Width = 240;
                button2.Width = 240;
                button3.Width = 240;
                button4.Width = 240;
                button5.Width = 240;
                button6.Width = 240;
                button7.Width = 240;
                button8.Width = 240;
                button9.Width = 240;

                buttonMenu.Text = "Menu";
                buttonMenu.TextImageRelation = TextImageRelation.ImageBeforeText;

                button1.Text = "Capturar poliza";
                button1.TextImageRelation = TextImageRelation.ImageBeforeText;

                button2.Text = "Capturar cheque";
                button2.TextImageRelation = TextImageRelation.ImageBeforeText;

                button3.Text = "Ver poliza";
                button3.TextImageRelation = TextImageRelation.ImageBeforeText;

                button4.Text = "Cambiar de directorio";
                button4.TextImageRelation = TextImageRelation.ImageBeforeText;

                button5.Text = "Datos de la emrpesa";
                button5.TextImageRelation = TextImageRelation.ImageBeforeText;

                button6.Text = "Estado financiero";
                button6.TextImageRelation = TextImageRelation.ImageBeforeText;

                button7.Text = "Auxiliar de mayor";
                button7.TextImageRelation = TextImageRelation.ImageBeforeText;

                button8.Text = "Directorio de costos";
                button8.TextImageRelation = TextImageRelation.ImageBeforeText;

                button9.Text = "Verificar actualización";
                button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else if (flowLayoutPanel3.Width > 235)
            {
                flowLayoutPanel3.Width = 55;
                buttonMenu.Width = 45;
                button1.Width = 45;
                button2.Width = 45;
                button3.Width = 45;
                button4.Width = 45;
                button5.Width = 45;
                button6.Width = 45;
                button7.Width = 45;
                button8.Width = 45;
                button9.Width = 45;

                buttonMenu.Text = string.Empty;
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button3.Text = string.Empty;
                button4.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button7.Text = string.Empty;
                button8.Text = string.Empty;
                button9.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapturaPoliza cf1 = new CapturaPoliza();

            cf1.MdiParent = this;
            cf1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 cheque = new Form5();

            cheque.MdiParent = this;
            cheque.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enlistarPolizas lista = new enlistarPolizas();
            lista.MdiParent = this;
            lista.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Mostrar el diálogo de selección de carpeta
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Asignar la ruta de la carpeta seleccionada a la variable generalPath en ConfiguracionGlobal
                    ConfiguracionGlobal.GeneralPath = folderBrowserDialog.SelectedPath + "/";
                    UpdateFileLine(ConfiguracionGlobal.GeneralPath);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatosEmpresa emp = new DatosEmpresa();
            emp.MdiParent = this;
            emp.Show();
        }
    }
}
