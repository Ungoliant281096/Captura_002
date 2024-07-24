using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WeifenLuo.WinFormsUI.Docking;
using static Captura.Class1;


namespace Captura
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;

            leerCatalogoMayor();

        }

        private void leerCatalogoMayor()
        {
            try
            {
                string mayorpath = ConfiguracionGlobal.GeneralPath + "CATMAY";
                int recordSize = Marshal.SizeOf(typeof(CATMAY));
                using (FileStream CATMAY = new FileStream(mayorpath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(CATMAY))
                {
                    long numRecords = CATMAY.Length / recordSize;

                    for (int i = 0; i < numRecords; i++)
                    {
                        CATMAY.Seek(i * recordSize, SeekOrigin.Begin);
                        byte[] buffer = reader.ReadBytes(recordSize);
                        GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

                        try
                        {
                            CATMAY record = (CATMAY)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(CATMAY));

                            if (!string.IsNullOrWhiteSpace(record.B1) ||
                                !string.IsNullOrWhiteSpace(record.B2) ||
                                !string.IsNullOrWhiteSpace(record.B5))
                            {
                                // Agregar una nueva fila al DataGridView con los valores del registro
                                dataGridView1.Rows.Add(record.B1.Trim(), record.B2.Trim(), record.B3.Trim(), record.B4.Trim(), record.B5.Trim());
                            }

                        }
                        finally
                        {
                            handle.Free();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }


    }
}
