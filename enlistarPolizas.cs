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
    public partial class enlistarPolizas : Form
    {
        public enlistarPolizas()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void enlistarPolizas_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string mesPoliza;

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "01";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 1:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "02";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 2:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "03";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 3:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "04";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 4:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "05";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 5:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "06";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 6:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "07";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 7:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "08";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 8:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "09";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 9:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "10";
                       // ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 10:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "11";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    case 11:
                        mesPoliza = ConfiguracionGlobal.GeneralArchive + "12";
                        //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                        break;
                    default:
                        return;
                }

                string rutaArchivo = ConfiguracionGlobal.GeneralPath + mesPoliza;
                int recordSize = Marshal.SizeOf(typeof(Operaciones));
                using (FileStream Operaciones = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(Operaciones))
                {
                    long numRecords = Operaciones.Length / recordSize;
                    dataGridView1.Rows.Clear();

                    for (int i = 0; i < numRecords; i++)
                    {
                        Operaciones.Seek(i * recordSize, SeekOrigin.Begin);
                        byte[] buffer = reader.ReadBytes(recordSize);
                        GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

                        try
                        {
                            Operaciones record = (Operaciones)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(Operaciones));

                            if (record.Indentificador == "A")
                            {
                                dataGridView1.Rows.Add(i, record.Cuenta.Trim(), record.Descripcion.Trim());
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
                MessageBox.Show("No encuentro el mes de operación.");
            }
        }
        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView2.ColumnCount = 6;

            dataGridView1.Columns[0].HeaderText = "#";
            dataGridView1.Columns[1].HeaderText = "N°";
            dataGridView1.Columns[2].HeaderText = "Descripción";

            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 220;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que la fila y columna son válidas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el valor de la celda en la columna 0 de la fila actual
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int registro))
                {
                    mostrarPoliza(registro, comboBox1.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("La celda está vacía o no contiene un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Índice de fila o columna fuera de rango.");
            }
        }

        private void mostrarPoliza(int registro, int mesIndex)
        {
            string mesPoliza;

            switch (mesIndex)
            {
                case 0:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "01";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 1:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "02";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 2:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "03";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 3:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "04";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 4:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "05";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 5:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "06";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 6:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "07";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 7:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "08";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 8:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "09";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 9:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "10";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 10:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "11";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                case 11:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "12";
                    //ConfiguracionGlobal.GuardarOperacion = mesPoliza;
                    break;
                default:
                    return;
            }

            string rutaArchivo = ConfiguracionGlobal.GeneralPath + mesPoliza;
            int recordSize = Marshal.SizeOf(typeof(Operaciones));
            using (FileStream operacionesFileStream = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(operacionesFileStream))
            {
                long fileLength = operacionesFileStream.Length;
                long numRecords = fileLength / recordSize;

                if (registro < numRecords)
                {
                    operacionesFileStream.Seek(registro * recordSize, SeekOrigin.Begin);
                    byte[] buffer;
                    GCHandle handle;
                    Operaciones record;

                    dataGridView2.Rows.Clear();

                    // Leer el primer registro
                    buffer = reader.ReadBytes(recordSize);
                    handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
                    try
                    {
                        // Encuentra el primer registro A (Encabezado)
                        record = (Operaciones)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(Operaciones));
                        label2.Text = record.Cuenta.Trim();
                        label3.Text = "Descripcion: " + record.Descripcion.Trim();

                    }
                    finally
                    {
                        handle.Free();
                    }

                    // Continuar leyendo hasta encontrar el siguiente identificador "A"
                    while (++registro < numRecords)
                    {
                        buffer = reader.ReadBytes(recordSize);
                        handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

                        try
                        {
                            record = (Operaciones)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(Operaciones));
                            //Detine la busqueda hasta encontrar otro identificador "A" 
                            if (record.Indentificador == "A")
                            {
                                break;
                            }
                            if(record.Indentificador != "D")
                            {
                                dataGridView2.Rows.Add(record.Cuenta.Trim(), record.Descripcion.Trim(), record.Fecha.Trim(), record.Importe.Trim());
                            }
                            else
                            {
                                label4.Text = ("Folio fiscal: " + record.Cuenta.Trim() + record.Descripcion.Trim());
                            }
                        }
                        finally
                        {
                            handle.Free();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El registro especificado está fuera del rango.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
