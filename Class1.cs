using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

namespace Captura
{
    internal class Class1
    {
        // Declarar la variable de tipo string
        public static class ConfiguracionGlobal
        {
            public static string GeneralPath { get; set; }
        }

        public Class1()
        {

        }
    }
}
