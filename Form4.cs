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
using System.Xml;

namespace Captura
{
    public partial class CapturaPoliza : Form
    {
        private int inicio;
        private int final;
        public CapturaPoliza()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveGridDataToFile(dataGridViewPoliza);
        }

        private void sumarDebeHaber()
        {
            decimal sumColumn4 = 0;
            decimal sumColumn5 = 0;

            foreach (DataGridViewRow row in dataGridViewPoliza.Rows)
            {
                if (row.Cells[4].Value != null && !string.IsNullOrWhiteSpace(row.Cells[4].Value.ToString()))
                {
                    if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal value4))
                    {
                        sumColumn4 += value4;
                    }
                }
                if (row.Cells[5].Value != null && !string.IsNullOrWhiteSpace(row.Cells[5].Value.ToString()))
                {
                    if (decimal.TryParse(row.Cells[5].Value.ToString(), out decimal value5))
                    {
                        sumColumn5 += value5;
                    }
                }
            }

            decimal sumaTotal = sumColumn4 + sumColumn5;

            textBox10.Text = sumColumn4.ToString("#,##0.00");
            textBox11.Text = sumColumn5.ToString("#,##0.00");
            textBox12.Text = sumaTotal.ToString("#,##0.00");

            if (sumaTotal < 0)
            {
                textBox12.ForeColor = Color.Red;
            }
            else if (sumaTotal > 0)
            {
                textBox12.ForeColor = Color.Green;
            }
            else if (sumaTotal == 0)
            {
                textBox12.ForeColor = Color.Blue;
            }

        }
        public void SaveGridDataToFile(DataGridView dataGridView)
        {
            string filePath = "C:/Users/fabian.cruz/Desktop/SAC001";

            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        Operaciones op = new Operaciones
                        {
                            Cuenta = row.Cells[0].Value?.ToString() ?? string.Empty,
                            Descripcion = row.Cells[1].Value?.ToString() ?? string.Empty,
                            Fecha = row.Cells[2].Value?.ToString() ?? string.Empty,
                            Importe = row.Cells[3].Value?.ToString() ?? string.Empty,
                            Indentificador = row.Cells[4].Value?.ToString() ?? string.Empty,
                            PosicionReal = row.Cells[5].Value?.ToString() ?? string.Empty
                        };

                        byte[] buffer = StructureToByteArray(op);
                        fs.Write(buffer, 0, buffer.Length);
                    }
                }
            }
            MessageBox.Show("Guardado");
        }

        private byte[] StructureToByteArray(Operaciones op)
        {
            int size = Marshal.SizeOf(op);
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);

            try
            {
                Marshal.StructureToPtr(op, ptr, true);
                Marshal.Copy(ptr, arr, 0, size);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return arr;
        }
        private void InitializeDataGridView()
        {
            dataGridViewPoliza.ColumnCount = 7;
            dataGridViewPoliza.RowCount = 300;

            dataGridViewPoliza.Columns[0].HeaderText = "Cuenta";
            dataGridViewPoliza.Columns[1].HeaderText = "Subcuenta";
            dataGridViewPoliza.Columns[2].HeaderText = "Nombre";
            dataGridViewPoliza.Columns[3].HeaderText = "Parcial";
            dataGridViewPoliza.Columns[4].HeaderText = "Debe";
            dataGridViewPoliza.Columns[5].HeaderText = "Haber";
            dataGridViewPoliza.Columns[6].HeaderText = "Concepto";

            dataGridViewPoliza.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewPoliza.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewPoliza.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridViewPoliza.Columns[5].DefaultCellStyle.Format = "N2";

            dataGridViewPoliza.Columns[0].Width = 50;
            dataGridViewPoliza.Columns[1].Width = 50;
            dataGridViewPoliza.Columns[2].Width = 250;
            dataGridViewPoliza.Columns[3].Width = 100;
            dataGridViewPoliza.Columns[4].Width = 100;
            dataGridViewPoliza.Columns[5].Width = 100;
            dataGridViewPoliza.Columns[6].Width = 200;

            dataGridViewPoliza.Columns[2].ReadOnly = true;


            foreach (DataGridViewColumn column in dataGridViewPoliza.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void dataGridViewPoliza_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            string valor = dataGridViewPoliza.CurrentCell.Value?.ToString();

            switch (e.ColumnIndex)
            {
                case 0:
                    HandleCuentaEdit(valor, e.RowIndex);
                    break;

                case 1:
                    HandleSubcuentaEdit(valor, e.RowIndex);
                    break;

                case 3:
                    HandleParcialEdit(valor);
                    break;
            }
            sumarDebeHaber();
        }
        private void HandleCuentaEdit(string valor, int rowIndex)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                SearchRecordByB1(valor);
            }

            SetCurrentCell(rowIndex, 1);
        }
        private void HandleSubcuentaEdit(string valor, int rowIndex)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                SearchRecordByC1(valor, inicio, final);
            }

            SetCurrentCell(rowIndex, 3);
        }
        private void HandleParcialEdit(string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                if (decimal.TryParse(dataGridViewPoliza.CurrentCell.Value?.ToString(), out decimal montoParcial))
                {
                    definirParcial(montoParcial);
                }
            }
        }
        private void SetCurrentCell(int rowIndex, int columnIndex)
        {
            try
            {
                dataGridViewPoliza.CurrentCell = dataGridViewPoliza.Rows[rowIndex].Cells[columnIndex];
            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void SearchRecordByB1(string searchValue)
        {
            int recordSize = Marshal.SizeOf(typeof(CATMAY));
            using (FileStream CATMAY = new FileStream("C:/Users/fabian.cruz/Desktop/CATMAY", FileMode.Open, FileAccess.Read))
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
                            int currentRowIndex = dataGridViewPoliza.CurrentCell.RowIndex;
                            DataGridViewRow currentRow = dataGridViewPoliza.Rows[currentRowIndex];
                            dataGridViewPoliza.Rows[currentRowIndex].Cells[2].Style.Font = new Font(dataGridViewPoliza.Font, FontStyle.Bold);
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
            MessageBox.Show($"No se encontró un registro {searchValue}");
        }
        private void SearchRecordByC1(string searchValue, int inicioC, int finalC)
        {
            int recordSize = Marshal.SizeOf(typeof(CATAUX));
            using (FileStream CATAUX = new FileStream("C:/Users/fabian.cruz/Desktop/CATAUX", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(CATAUX))
            {
                long numRecords = CATAUX.Length / recordSize;
                string cuenta = dataGridViewPoliza.Rows[dataGridViewPoliza.CurrentCell.RowIndex - 1].Cells[0].Value?.ToString() ?? string.Empty;

                for (int i = inicioC - 1; i < finalC - 1; i++)
                {
                    CATAUX.Seek(i * recordSize, SeekOrigin.Begin);
                    byte[] buffer = reader.ReadBytes(recordSize);
                    GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

                    try
                    {
                        CATAUX record = (CATAUX)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(CATAUX));

                        if (record.C1.Trim() == searchValue)
                        {
                            int currentRowIndex = dataGridViewPoliza.CurrentCell.RowIndex;
                            DataGridViewRow currentRow = dataGridViewPoliza.Rows[currentRowIndex];
                            currentRow.Cells[2].Value = record.C2;

                            currentRow.Cells[6].Value = textBox2.Text;
                            return;
                        }
                    }
                    finally
                    {
                        handle.Free();
                    }
                }
            }
            MessageBox.Show($"No se encontró un registro {searchValue}");
        }
        private void definirParcial(decimal monto)
        {
            int currentRowIndex = dataGridViewPoliza.CurrentCell.RowIndex;

            if (monto > 0)
            {
                dataGridViewPoliza.Rows[currentRowIndex].Cells[4].Value = monto;
                dataGridViewPoliza.Rows[currentRowIndex].Cells[3].Value = monto;
            }
            else
            {
                dataGridViewPoliza.Rows[currentRowIndex].Cells[5].Value = monto;
                dataGridViewPoliza.Rows[currentRowIndex].Cells[3].Value = monto;
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridViewPoliza.Rows.Clear();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
        private void ExtractInfoFromXml(string xmlFilePath)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFilePath);

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/4");
                nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital");

                XmlNode uuidNode = doc.SelectSingleNode("//tfd:TimbreFiscalDigital", nsmgr);
                XmlNode rfcNode = doc.SelectSingleNode("//cfdi:Emisor", nsmgr);
                XmlNode beneficiarioNode = doc.SelectSingleNode("//cfdi:Emisor/@Nombre", nsmgr);

                if (uuidNode != null && rfcNode != null && beneficiarioNode != null)
                {
                    string uuid = uuidNode.Attributes["UUID"]?.Value;
                    string rfc = rfcNode.Attributes["Rfc"]?.Value;
                    string beneficiario = beneficiarioNode.Value;

                    textBox1.Text = rfc;
                    textBox3.Text = uuid;

                    addFiscalFolio(uuid);
                }
                else
                {
                    MessageBox.Show("No se encontraron los datos necesarios en el archivo XML.");
                }
            }
            catch
            {
                openFileDialog1.FileName = string.Empty;
                return;
            }
        }
        private void addFiscalFolio(string folioFiscal)
        {
            // Verificar si el path es nulo o vacío
            if (string.IsNullOrEmpty(folioFiscal))
            {
                return;
            }
            try
            {
                ImageList imageList = new ImageList();
                imageList.Images.Add(Image.FromFile("C:/Users/fabian.cruz/Desktop/IconosCaptura/cheque.png"));
                listView3.SmallImageList = imageList;

                listView3.View = View.Details;
                listView3.FullRowSelect = true;
                listView3.GridLines = true;

                ListViewItem item = new ListViewItem(folioFiscal);
                item.ImageIndex = 0;

                listView3.Items.Add(item);

                this.Controls.Add(listView3);

            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void CreateMyListViewXml(string path)
        {
            // Verificar si el path es nulo o vacío
            if (string.IsNullOrEmpty(path))
            {
                return;
            }
            try
            {
                ImageList imageList = new ImageList();
                imageList.Images.Add(Image.FromFile("C:/Users/fabian.cruz/Desktop/IconosCaptura/xml.png"));
                listView1.SmallImageList = imageList;

                listView1.View = View.Details;
                listView1.FullRowSelect = true;
                listView1.GridLines = true;

                ListViewItem item = new ListViewItem(path);
                item.ImageIndex = 0;

                listView1.Items.Add(item);

                this.Controls.Add(listView1);

            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void CreateMyListViewPdf(string path)
        {
            // Verificar si el path es nulo o vacío
            if (string.IsNullOrEmpty(path))
            {
                return;
            }
            try
            {
                ImageList imageList = new ImageList();
                imageList.Images.Add(Image.FromFile("C:/Users/fabian.cruz/Desktop/IconosCaptura/pdf.png"));
                listView2.SmallImageList = imageList;

                listView2.View = View.Details;
                listView2.FullRowSelect = true;
                listView2.GridLines = true;

                ListViewItem item = new ListViewItem(path);
                item.ImageIndex = 0;

                listView2.Items.Add(item);

                this.Controls.Add(listView2);

            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void Pegar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto_copiado = Clipboard.GetText();
                string[] lineas = texto_copiado.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                int error = 0;
                int fila = dataGridViewPoliza.CurrentCell.RowIndex;
                int columna = dataGridViewPoliza.CurrentCell.ColumnIndex;
                DataGridViewCell objeto_celda;
                dataGridViewPoliza.Columns[2].ReadOnly = false;

                foreach (string linea in lineas)
                {
                    if (fila < dataGridViewPoliza.RowCount && linea.Length > 0)
                    {
                        string[] celdas = linea.Split('\t');

                        for (int indice = 0; indice < celdas.Length; ++indice)
                        {
                            if (columna + indice < dataGridViewPoliza.ColumnCount)
                            {
                                objeto_celda = dataGridViewPoliza[columna + indice, fila];
                                if (!objeto_celda.ReadOnly && objeto_celda != null)
                                {
                                    if (objeto_celda.Value == null || objeto_celda.Value.ToString() != celdas[indice])
                                    {
                                        if (objeto_celda.ValueType != null)
                                        {
                                            objeto_celda.Value = Convert.ChangeType(celdas[indice], objeto_celda.ValueType);
                                        }
                                        else
                                        {
                                            objeto_celda.Value = celdas[indice];
                                        }
                                    }
                                }
                                else
                                {
                                    error++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        fila++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (error > 0)
                {
                    MessageBox.Show(string.Format("{0} celdas no pueden ser actualizadas debido a que son de solo lectura.", error),
                                    "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dataGridViewPoliza.Columns[2].ReadOnly = true;
            }
            catch (FormatException fexcepcion)
            {
                MessageBox.Show("Los datos que pegó están en el formato incorrecto para la celda." + "\n\nDETALLES: \n\n" + fexcepcion.Message,
                                "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (NullReferenceException nexcepcion)
            {
                MessageBox.Show("Se ha encontrado una referencia nula en una de las celdas." + "\n\nDETALLES: \n\n" + nexcepcion.Message,
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            CreateMyListViewXml(openFileDialog1.FileName);
            ExtractInfoFromXml(openFileDialog1.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog(this);
            CreateMyListViewPdf(openFileDialog1.FileName);
        }
        private void CapturaPoliza_Resize(object sender, EventArgs e)
        {
            dataGridViewPoliza.Height = this.ClientSize.Height - dataGridViewPoliza.Top - 20;

        }
        private void buttonCuenta_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void buttonSubcuenta_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.leerCatalogoAuxiliar(inicio, final);
        }


    }
}
