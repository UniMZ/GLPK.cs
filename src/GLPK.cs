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
            {
                dist = RuntimeInformation.ProcessArchitecture switch
                {
                    Architecture.X64 => "x86_64-linux-gnu",
                    _ => dist
                };
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                dist = RuntimeInformation.ProcessArchitecture switch
                {
                    Architecture.X64 => "x86_64-apple-darwin",
                    Architecture.Arm64 => "aarch64-apple-darwin",
                    _ => dist
                };
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                dist = RuntimeInformation.ProcessArchitecture switch
                {
                    Architecture.X64 => "x86_64-w64-mingw32",
                    _ => dist
                };
            }
            return NativeLibrary.Load($"lib/GLPK-{dist}/lib/libglpk", assembly, path);
        }
        return IntPtr.Zero;
    }
}
