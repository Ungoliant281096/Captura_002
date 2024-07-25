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
//using static Captura.Class1;

namespace Captura
{
    public partial class DatosEmpresa : Form
    {
        public DatosEmpresa()
        {
            InitializeComponent();
        }

        private void DatosEmpresa_Load(object sender, EventArgs e)
        {
            leerDatosEmpresa();
        }

        private void leerDatosEmpresa()
        {
            try
            {
                string rutaDatos = ConfiguracionGlobal.GeneralPath + "DATOS";
                int recordSize = Marshal.SizeOf(typeof(datosEmpresa));
                using (FileStream datosEmpresaStream = new FileStream(rutaDatos, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(datosEmpresaStream))
                {
                    datosEmpresaStream.Seek(0, SeekOrigin.Begin);
                    byte[] buffer = reader.ReadBytes(recordSize);
                    GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
                    datosEmpresa record = (datosEmpresa)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(datosEmpresa));
                    handle.Free();

                    textBox1.Text = record.D1.Trim();
                    textBox2.Text = record.D2.Trim();
                    textBox3.Text = record.anioActual.Trim();
                    textBox4.Text = record.nombreArchivo.Trim();

                    ConfiguracionGlobal.GeneralArchive = record.nombreArchivo.Trim();
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void guardarDatosEmpresa(datosEmpresa nuevoRegistro, long position)
        {
            string rutaDatos = ConfiguracionGlobal.GeneralPath + "DATOS";
            int recordSize = Marshal.SizeOf(typeof(datosEmpresa));
            byte[] buffer = new byte[recordSize];
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            Marshal.StructureToPtr(nuevoRegistro, handle.AddrOfPinnedObject(), false);
            handle.Free();

            using (FileStream datosEmpresaStream = new FileStream(rutaDatos, FileMode.Open, FileAccess.Write))
            {
                datosEmpresaStream.Seek(position, SeekOrigin.Begin);
                datosEmpresaStream.Write(buffer, 0, recordSize);
            }
        }

        private void actualizarPrimerRegistro(datosEmpresa nuevoRegistro)
        {
            guardarDatosEmpresa(nuevoRegistro, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datosEmpresa nuevoRegistro = new datosEmpresa
            {
                D1 = textBox1.Text,
                D2 = textBox2.Text,
                nombreArchivo = textBox4.Text,
                anioActual = textBox3.Text,
            };

            actualizarPrimerRegistro(nuevoRegistro);
            leerDatosEmpresa();
        }

    }
}
