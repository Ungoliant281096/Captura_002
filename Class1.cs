using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct Operaciones
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string Cuenta;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
    public string Descripcion;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public string Fecha;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string Importe;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string Indentificador;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public string PosicionReal;
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct CATMAY
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string B1;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string B2;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string B3;

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

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct datosEmpresa
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string D1;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 60)]
    public string D2;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 45)]
    public string D3;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public string nombreArchivo;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string anioActual;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 25)]
    public string otrosDatos;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string ultimaPoliza;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string utimoRegistro;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public string otrosRegistros;
}

public static class ConfiguracionGlobal
{
    public static string GeneralPath { get; set; }
    public static string GeneralArchive { get; set; }
    public static string GuardarOperacion { get; set; }
}

public static class variablesGlobales
{
    public static string B1Catmay { get; set; }
    public static string B2Catmay { get; set; }
    public static string B3Catmay { get; set; }
    public static string B4Catmay { get; set; }
    public static string B5Catmay { get; set; }

}
public static class ArchivoManager
{
    public static void AbrirArchivoCATMAY()
    {
        try
        {
            string mayorPath = ConfiguracionGlobal.GeneralPath + "CATMAY";
            int recordSize = Marshal.SizeOf(typeof(CATMAY));
            using (FileStream fileStream = new FileStream(mayorPath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                long numRecords = fileStream.Length / recordSize;

                for (int i = 0; i < numRecords; i++)
                {
                    fileStream.Seek(i * recordSize, SeekOrigin.Begin);
                    byte[] buffer = reader.ReadBytes(recordSize);
                    GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

                    try
                    {
                        CATMAY record = (CATMAY)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(CATMAY));
                        // Asigna los valores del registro a variables globales o realiza otras operaciones necesarias
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
            MessageBox.Show($"Error al abrir el archivo: {ex.Message}");
        }
    }
    public static void leerDatosEmpresa()
    {
        try
        {
            string filePath = "C:/GconTA/Gcont.Arr";
            string fileContent;

            if (File.Exists(filePath))
            {
                fileContent = File.ReadAllText(filePath);
            }
            else
            {
                throw new FileNotFoundException("File not found.");
            }

            ConfiguracionGlobal.GeneralPath = fileContent;

            string rutaDatos = Path.Combine(ConfiguracionGlobal.GeneralPath, "DATOS");
            int recordSize = Marshal.SizeOf(typeof(datosEmpresa));

            using (FileStream datosEmpresaStream = new FileStream(rutaDatos, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(datosEmpresaStream))
            {
                datosEmpresaStream.Seek(0, SeekOrigin.Begin);
                byte[] buffer = reader.ReadBytes(recordSize);
                GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
                datosEmpresa record = (datosEmpresa)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(datosEmpresa));
                handle.Free();

                ConfiguracionGlobal.GeneralArchive = record.nombreArchivo.Trim();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

}
