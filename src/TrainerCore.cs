```csharp
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class ProcessMemory
{
    private Process process;
    private IntPtr processHandle;

    // Minecraft specific static addresses (example values)
    private const int HEALTH_ADDRESS = 0x12345678; // Example address for health
    private const int EXPERIENCE_ADDRESS = 0x12345679; // Example address for experience

    public bool AttachToProcess(string processName)
    {
        try
        {
            process = Process.GetProcessesByName(processName)[0];
            processHandle = OpenProcess(ProcessAccessFlags.All, false, process.Id);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool IsGameRunning(string processName)
    {
        return Process.GetProcessesByName(processName).Length > 0;
    }

    public float ReadFloat(int address)
    {
        byte[] buffer = new byte[4];
        ReadProcessMemory(processHandle, (IntPtr)address, buffer, buffer.Length, out _);
        return BitConverter.ToSingle(buffer, 0);
    }

    public void WriteFloat(int address, float value)
    {
        byte[] buffer = BitConverter.GetBytes(value);
        WriteProcessMemory(processHandle, (IntPtr)address, buffer, buffer.Length, out _);
    }

    public int ReadInt(int address)
    {
        byte[] buffer = new byte[4];
        ReadProcessMemory(processHandle, (IntPtr)address, buffer, buffer.Length, out _);
        return BitConverter.ToInt32(buffer, 0);
    }

    public void WriteInt(int address, int value)
    {
        byte[] buffer = BitConverter.GetBytes(value);
        WriteProcessMemory(processHandle, (IntPtr)address, buffer, buffer.Length, out _);
    }

    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

    [DllImport("kernel32.dll")]
    private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesWritten);

    [Flags]
    public enum ProcessAccessFlags : uint
    {
        All = 0x001F0FFF,
        // Add other necessary flags here as needed
    }
}
```

This C# class provides a basic structure to handle memory reading and writing for a Minecraft AFK clicker tool, including static memory addresses for sample game values like health and experience.