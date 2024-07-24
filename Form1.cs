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
using static Captura.Class1;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string B4;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string B5;
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct CATAUX
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string C1;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string C2;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string C3;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string C4;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string C5;
}

namespace Captura
{
    public partial class Form1 : Form
    {
        public int inicio;
        public int final;

        private Dictionary<int, string> cuentas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel3.Width < 250)
            {
                flowLayoutPanel3.Width = 250;
                buttonMenu.Width = 245;
                button1.Width = 245;
                button2.Width = 245;
                button3.Width = 245;
                button4.Width = 245;

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
            }
            else if (flowLayoutPanel3.Width > 249)
            {
                flowLayoutPanel3.Width = 45;
                buttonMenu.Width = 45;
                button1.Width = 45;
                button2.Width = 45;
                button3.Width = 45;
                button4.Width = 45;

                buttonMenu.Text = string.Empty;
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button3.Text = string.Empty;
                button4.Text = string.Empty;


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

                }
            }
        }
    }
}
