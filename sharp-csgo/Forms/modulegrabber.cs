using luxe_csgo.General;
using luxe_csgo.Globals;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace luxe_csgo {
    public partial class modulegrabber : Form {
        public modulegrabber() {
            InitializeComponent();
            formstuff.movable(lblOnii, this);
            formstuff.movable(lblPlss, this);
            formstuff.movable(pnlBackground, this);
            formstuff.movable(pictureBox1, this);
            update_timer.Start();
        }

        void uwudate() {
            // make sure csgo is open.
            Process[] prowocess = Process.GetProcessesByName("csgo");
            if (prowocess.Length < 1) return;

            Process csgowo = prowocess[0];
            // loop through all modules and get client and engine base address.
            foreach (ProcessModule moduwule in csgowo.Modules) {
                if (moduwule.ModuleName == "client_panorama.dll") basevaluwus.m_ClientPointer = (int)moduwule.BaseAddress;
                if (moduwule.ModuleName == "engine.dll") basevaluwus.m_EnginePointer = (int)moduwule.BaseAddress;
            }
            basevaluwus.csgoWindow = csgowo.MainWindowHandle;

            // confirm we successfully retrieved module base addresses.
            if (!(basevaluwus.m_ClientPointer > 0)) return;
            if (!(basevaluwus.m_EnginePointer > 0)) return;

            // done. lets gather offsets.
            oofsets.setoofsets();

            // lets initialize our memory class now
            memory.Initialize("csgo");

            // stop timer after passing previus checks. create our main form.
            update_timer.Stop();
            Form main = new main();
            main.Show();
            Hide();
        }

        private void update_timer_Tick(object sender, EventArgs e) {
            uwudate();
        }
    }
}
