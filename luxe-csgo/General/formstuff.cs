using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luxe_csgo.General {
    class formstuff {


        // this is for making the form components movable since we arent using an actual window
        private static bool dragging = false;
        private static int xoff = 0, yoff = 0;

        private static void mousedown(Form f) {
            dragging = true;
            xoff = Cursor.Position.X - f.Location.X;
            yoff = Cursor.Position.Y - f.Location.Y;
        }

        private static void mousemove(Form f) {
            if (dragging) {
                f.Location = new Point(Cursor.Position.X - xoff, Cursor.Position.Y - yoff);
                f.Update();
            }
        }

        private static void mouseup() {
            dragging = false;
        }


        // create events.
        public static void movable(Label label, Form f) {
            label.MouseDown += (s, e) => mousedown(f);
            label.MouseMove += (s, e) => mousemove(f);
            label.MouseUp += (s, e) => mouseup();
        }

        public static void movable(Panel panel, Form f) {
            panel.MouseDown += (s, e) => mousedown(f);
            panel.MouseMove += (s, e) => mousemove(f);
            panel.MouseUp += (s, e) => mouseup();
        }

        public static void movable(PictureBox pbox, Form f) {
            pbox.MouseDown += (s, e) => mousedown(f);
            pbox.MouseMove += (s, e) => mousemove(f);
            pbox.MouseUp += (s, e) => mouseup();
        }

    }
}
