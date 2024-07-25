using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Captura.Class1;

namespace Captura
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;

        }
        public void leerCatalogoAuxiliar(int incio, int final)
        {
            try
            {
                string auxiliarPath = ConfiguracionGlobal.GeneralPath + "CATAUX";
                int recordSize = Marshal.SizeOf(typeof(CATAUX));
                using (FileStream CATAUX = new FileStream(auxiliarPath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(CATAUX))
                {
                    long numRecords = CATAUX.Length / recordSize;

                    for (int i = incio; i < final; i++)
                    {
                        CATAUX.Seek(i * recordSize, SeekOrigin.Begin);
                        byte[] buffer = reader.ReadBytes(recordSize);
                        GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

                        try
                        {
                            CATAUX record = (CATAUX)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(CATAUX));

                            if (!string.IsNullOrWhiteSpace(record.C1) ||
                                !string.IsNullOrWhiteSpace(record.C2) ||
                                !string.IsNullOrWhiteSpace(record.C5))
                            {

                                dataGridView1.Rows.Add(i, record.C1.Trim(), record.C2.Trim(), record.C3.Trim(), record.C4.Trim(), record.C5.Trim());
                            }
                        }
                        finally
                        {
                            handle.Free();
                        }
                    }
                }
            }
            catch (Exception ex) {
                return;
            }
        }
    }
}
