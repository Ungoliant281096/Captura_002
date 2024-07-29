using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Captura.Class1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Captura
{

    public partial class enlistarPolizas : Form
    {
        int inicio;
        int final;
        public enlistarPolizas()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView2.ColumnCount = 8;

            dataGridView1.Columns[0].HeaderText = "#";
            dataGridView1.Columns[1].HeaderText = "N°";
            dataGridView1.Columns[2].HeaderText = "Descripción";

            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 220;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;

            dataGridView2.Columns[0].HeaderText = "Cuenta";
            dataGridView2.Columns[1].HeaderText = "Subcuenta";
            dataGridView2.Columns[2].HeaderText = "Nombre";
            dataGridView2.Columns[3].HeaderText = "Parcial";
            dataGridView2.Columns[4].HeaderText = "Debe";
            dataGridView2.Columns[5].HeaderText = "Haber";
            dataGridView2.Columns[6].HeaderText = "Redaccion";
            dataGridView2.Columns[7].HeaderText = "Folio fiscal";


            dataGridView2.Columns[0].Width = 50;
            dataGridView2.Columns[1].Width = 50;
            dataGridView2.Columns[2].Width = 250;
            dataGridView2.Columns[3].Width = 100;
            dataGridView2.Columns[4].Width = 100;
            dataGridView2.Columns[5].Width = 100;
            dataGridView2.Columns[6].Width = 250;
            dataGridView2.Columns[7].Width = 250;

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
                // instrucciones para abrir el random en mapa de bytes
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
                    break;
                case 1:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "02";
                    break;
                case 2:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "03";
                    break;
                case 3:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "04";
                    break;
                case 4:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "05";
                    break;
                case 5:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "06";
                    break;
                case 6:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "07";
                    break;
                case 7:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "08";
                    break;
                case 8:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "09";
                    break;
                case 9:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "10";
                    break;
                case 10:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "11";
                    break;
                case 11:
                    mesPoliza = ConfiguracionGlobal.GeneralArchive + "12";
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

                            if (record.Indentificador == "B") //cuentas
                            {

                                if (decimal.Parse(record.Importe) > 0)
                                {// Positivo debe
                                 // cuenta , subcuenta, nombre, parcial, debe, haber, redaccion, folio
                                    dataGridView2.Rows.Add(record.Cuenta.Trim(), "", "", "", record.Importe, "", record.Descripcion.Trim());
                                }
                                else
                                {// Negativo haber
                                 // cuenta , subcuenta, nombre, parcial, debe, haber, redaccion, folio
                                    dataGridView2.Rows.Add(record.Cuenta.Trim(), "", "", "", "", record.Importe, record.Descripcion.Trim());

                                }
                            }
                            else if (record.Indentificador == "C") //subcuentas
                            {

                                if (decimal.Parse(record.Importe) > 0)
                                {// Positivo debe
                                 // cuenta , subcuenta, nombre, parcial, debe, haber, redaccion, folio
                                    dataGridView2.Rows.Add("", record.Cuenta.Trim(), "", record.Importe, "", "", record.Descripcion.Trim());
                                }
                                else
                                {// Negativo haber
                                 // cuenta , subcuenta, nombre, parcial, debe, haber, redaccion, folio
                                    dataGridView2.Rows.Add("", record.Cuenta.Trim(), "", record.Importe, "", "", record.Descripcion.Trim());

                                }
                            }
                            else if (record.Indentificador == "D") //encasbezdo
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
            encontrarMovimientos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void enlistarPolizas_Resize(object sender, EventArgs e)
        {
            dataGridView2.Width = this.ClientSize.Width - 450;
            dataGridView2.Height = this.ClientSize.Height - dataGridView2.Top - 20;
            dataGridView1.Height = this.ClientSize.Height - dataGridView1.Top - 20;
        }

        private void SearchRecordByC1(string cuenta, string searchValue, int inicioC, int finalC, int fila)
        {
            try
            {
                string auxiliarPath = ConfiguracionGlobal.GeneralPath + "CATAUX";
                int recordSize = Marshal.SizeOf(typeof(CATAUX));
                using (FileStream CATAUX = new FileStream(auxiliarPath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(CATAUX))
                {
                    long numRecords = CATAUX.Length / recordSize;
                    //string cuenta = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex - 1].Cells[0].Value?.ToString() ?? string.Empty;
                    
                    for (int i = inicioC - 1; i < finalC - 1; i++)
                    {
                        CATAUX.Seek(i * recordSize, SeekOrigin.Begin);
                        byte[] buffer = reader.ReadBytes(recordSize);
                        GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

                        try
                        {
                            CATAUX record = (CATAUX)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(CATAUX));

                            if (i.ToString() == searchValue)
                            {
                                int currentRowIndex = dataGridView2.CurrentCell.RowIndex;
                                DataGridViewRow currentRow = dataGridView2.Rows[fila];
                                currentRow.Cells[2].Value = record.C2;

                                return;
                            }
                        }
                        finally
                        {
                            handle.Free();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show($"No se encontró un registro {searchValue}");
            }
        }

        private void SearchRecordByB1(string searchValue, int fila)
        {
            try
            {
                string mayorPath = ConfiguracionGlobal.GeneralPath + "CATMAY";
                int recordSize = Marshal.SizeOf(typeof(CATMAY));
                using (FileStream CATMAY = new FileStream(mayorPath, FileMode.Open, FileAccess.Read))
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

                            if (record.B1.Trim() == searchValue)
                            {
                                //int currentRowIndex = dataGridView2.CurrentCell.RowIndex;
                                DataGridViewRow currentRow = dataGridView2.Rows[fila];
                                dataGridView2.Rows[fila].Cells[2].Style.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                                currentRow.DefaultCellStyle.BackColor = Color.FromArgb(235, 244, 246);
                                currentRow.Cells[2].Value = record.B2;

                                inicio = int.Parse(record.B4);
                                final = int.Parse(record.B5);

                                return;
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
                MessageBox.Show($"No se encontró un registro {searchValue}");
            }
        }
        private void SetCurrentCell(int rowIndex, int columnIndex)
        {
            try
            {
                dataGridView2.CurrentCell = dataGridView2.Rows[rowIndex].Cells[columnIndex];
            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void encontrarMovimientos()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (!dataGridView2.Rows[i].IsNewRow)
                {
                    var valor = dataGridView2.Rows[i].Cells[0].Value;

                    // Verificar si la celda no está vacía
                    if (valor != null && !string.IsNullOrWhiteSpace(valor.ToString()))
                    {
                        // Procesar la cuenta principal
                        SearchRecordByB1(valor.ToString(), i);

                        string cuenta = valor.ToString();

                        // Buscar subcuentas empezando desde la fila siguiente a la actual
                        for (int j = i + 1; j < dataGridView2.Rows.Count; j++)
                        {
                            if (!dataGridView2.Rows[j].IsNewRow)
                            {
                                var valorSub = dataGridView2.Rows[j].Cells[1].Value;

                                // Verificar si la celda no está vacía
                                if (valorSub != null && !string.IsNullOrWhiteSpace(valorSub.ToString()))
                                {
                                    // Procesar la subcuenta
                                    SearchRecordByC1(cuenta, valorSub.ToString(), inicio, final, j);
                                }
                                else
                                {
                                    // Si la celda está vacía, salir del segundo for
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
