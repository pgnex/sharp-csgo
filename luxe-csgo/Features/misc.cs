using luxe_csgo.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public static class misc {
    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern short GetAsyncKeyState(System.Int32 vKey);

    public static void bunny_hop() {
        while (true) {
            if (memory.ReadMemory<int>(basevaluwus.m_ClientPointer + signatures.dwForceJump) == 5) {
                while (GetAsyncKeyState(32) != 0) {
                    if (memory.ReadMemory<int>(luxe.local_player + netvars.m_fFlags) == 257) {
                        memory.WriteMemory<int>(basevaluwus.m_ClientPointer + signatures.dwForceJump, 5);
                        Thread.Sleep(25);
                        memory.WriteMemory<int>(basevaluwus.m_ClientPointer + signatures.dwForceJump, 4);
                    }
                }
            }
            Thread.Sleep(1);
        }
    }

    public static void refresh_info() {
        while (true) {
            luxe.local_player = memory.ReadMemory<int>(basevaluwus.m_ClientPointer + signatures.dwLocalPlayer);
            Thread.Sleep(100);
        }
    }

}