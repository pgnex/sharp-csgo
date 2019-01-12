using luxe_csgo.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luxe_csgo {
    public partial class main : Form {
        public main() {
            InitializeComponent();

            JexTabs tabs;
            tabs = new JexTabs();
            tabs.AddTab(pnlAimbot, pnlTabAimbot, lblTabAimbot);
            tabs.AddTab(pnlVisuals, pnlTabVisuals, lblTabVisuals);
            tabs.AddTab(pnlTrigger, pnlTabTrigger, lblTabTrigger);
            tabs.AddTab(pnlMisc, pnlTabMisc, lblTabMisc);
            tabs.AddTab(pnlConfigs, pnlTabConfigs, lblTabConfigs);
            tabs.Initialized();
        }

    }
}