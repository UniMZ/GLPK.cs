namespace UniMZ.GLPK;

using System.Reflection;
using System.Runtime.InteropServices;

public static partial class GLPK
{
    static GLPK() { NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), DllImportResolver); }

    private static IntPtr DllImportResolver(string name, Assembly assembly, DllImportSearchPath? path)
    {
        var dist = "unknown";
        if (name == "GLPK")
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                dist = "x86_64-linux-gnu";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                dist = "aarch64-apple-darwin";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && 
                (RuntimeInformation.ProcessArchitecture == Architecture.X64 || 
                 RuntimeInformation.ProcessArchitecture == Architecture.X86))
                dist = "x86_64-apple-darwin";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                dist = "x86_64-w64-mingw32";
            return NativeLibrary.Load($"lib/GLPK-{dist}/lib/libglpk", assembly, path);
        }
        return IntPtr.Zero;
    }
}
