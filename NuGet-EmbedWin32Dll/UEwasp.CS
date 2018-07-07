using System.Runtime.InteropServices;

namespace EmbedWin32Dll
{
    internal static class UEwasp
    {
        [DllImport("UEwasp.dll")]
        public static extern void SETSTD_WASP(int stdid);

        [DllImport("UEwasp.dll")]
        public static extern void P2T(double p, ref double t, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void P2VL(double p, ref double v, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void P2VG(double p, ref double v, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void P2HL(double p, ref double h, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void P2HG(double p, ref double h, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void P2KSG(double p, ref double ks, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void P2KSL(double p, ref double ks, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void P2ETAL(double p, ref double h, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void P2ETAG(double p, ref double h, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void T2P(double t, ref double p, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void T2VL(double p, ref double v, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void T2VG(double p, ref double v, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void T2HL(double p, ref double h, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void T2HG(double p, ref double h, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void T2KSG(double p, ref double ks, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void T2KSL(double p, ref double ks, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void T2ETAL(double p, ref double h, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void T2ETAG(double p, ref double h, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void PT2V(double p, double t, ref double v, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void PT2H(double p, double T, ref double h, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void PT2ETA(double p, double T, ref double cp, ref int range);

        [DllImport("UEwasp.dll")]
        public static extern void PT2KS(double p, double T, ref double ks, ref int range);
    }
}