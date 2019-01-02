using luxe_csgo.Globals;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace luxe_csgo {
    public partial class ModuleGrabber : Form {
        public ModuleGrabber() {
            InitializeComponent();
            uwudate(); // lets gather some base values and make sure csgo is open.
        }

        void uwudate() {
            while (true) {
                // optimization xD.
                Thread.Sleep(500);
                // make sure csgo is open.
                Process[] prowocess = Process.GetProcessesByName("csgo");
                if (prowocess.Length < 1) continue;

                Process csgowo = prowocess[0];
                // loop through all modules and get client and engine base address.
                foreach (ProcessModule moduwule in csgowo.Modules) {
                    if (moduwule.ModuleName == "client_panorama.dll") oofsets.m_ClientPointer = (int)moduwule.BaseAddress;
                    if (moduwule.ModuleName == "engine.dll") oofsets.m_EnginePointer = (int)moduwule.BaseAddress;
                }
                oofsets.csgoWindow = csgowo.MainWindowHandle;

                // confirm we successfully retrieved module base addresses.
                if (!(oofsets.m_ClientPointer > 0)) continue;
                if (!(oofsets.m_EnginePointer > 0)) continue;
                // lets exit the loop.
                break;
            }
            // done. lets gather offsets.
        }
    }
}
