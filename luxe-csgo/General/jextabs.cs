using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// credit to justin (github.com/ooojustin) & nex (github.com/nexzoz) from previous project.

class JexTabs {

    internal class JexTab {

        JexTabs parent;
        Panel pnlMain, pnlTab;
        Label lblTab;

        public JexTab(Panel pnlMain, Panel pnlTab, Label lblTab) {
            this.pnlMain = pnlMain;
            this.pnlTab = pnlTab;
            this.lblTab = lblTab;
        }

        public void SetParent(JexTabs parent) {
            this.parent = parent;
        }

        public void Hide() {
            pnlMain.Visible = false;
        }

        public void ResetColors() {
            lblTab.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            pnlTab.BackColor = System.Drawing.Color.FromArgb(16, 18, 22);
        }

        public void Select() {
            parent.HideTabs();
            parent.ResetColors();
            lblTab.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            pnlTab.BackColor = System.Drawing.Color.FromArgb(32, 34, 44);
            pnlMain.Visible = true;
        }

    }

    List<JexTab> tabList;

    public JexTabs() {
        tabList = new List<JexTab>();
    }

    public void AddTab(Panel pnlMain, Panel pnlTab, Label lblTab) {
        JexTab tab = new JexTab(pnlMain, pnlTab, lblTab);
        tab.SetParent(this);
        tabList.Add(tab);
        lblTab.Click += (s, e) => tab.Select();
        pnlTab.Click += (s, e) => tab.Select();
    }

    public void HideTabs() {
        foreach (JexTab tab in tabList)
            tab.Hide();
    }

    public void ResetColors() {
        foreach (JexTab tab in tabList)
            tab.ResetColors();
    }

    public void Initialized() {
        tabList[0].Select();
    }

}
