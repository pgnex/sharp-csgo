using luxe_csgo.General;
using luxe_csgo.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luxe_csgo {
    public partial class main : Form {
        public main() {
            InitializeComponent();

            // create our movables
            formstuff.movable(pnlTop, this);
            formstuff.movable(lblTitle, this);

            // create instance of jex tabs and create our tabs..
            JexTabs tabs;
            tabs = new JexTabs();
            tabs.AddTab(pnlAimbot, pnlTabAimbot, lblTabAimbot);
            tabs.AddTab(pnlVisuals, pnlTabVisuals, lblTabVisuals);
            tabs.AddTab(pnlTrigger, pnlTabTrigger, lblTabTrigger);
            tabs.AddTab(pnlMisc, pnlTabMisc, lblTabMisc);
            tabs.AddTab(pnlConfigs, pnlTabConfigs, lblTabConfigs);
            tabs.Initialized();

            Thread refresh_thread = new Thread(misc.refresh_info);
            refresh_thread.Start();

            Thread bhop_thread = new Thread(misc.bunny_hop);
            bhop_thread.Start();
        }

    }
}