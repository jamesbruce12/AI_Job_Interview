using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Job_Interview
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OnlineInterviewFormBackground());
        }
    }
}

//Allows us to have a round "Send" button in the program
class RoundButton : Button
{
    protected override void OnResize(EventArgs e)
    {
        using (var path = new GraphicsPath())
        {
            path.AddEllipse(new Rectangle(2, 2, this.Width - 5, this.Height - 5));
            this.Region = new Region(path);
        }
        base.OnResize(e);
    }
}
