//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocialMediaAggregator.Forms;
using SocialMediaAggregator.Controllers;

namespace SocialMediaAggregator
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

            // We need to pass in a valid instance of the MainControllerBase.
            Application.Run(new MainForm(null));
        }
    }
}
