using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlibaixe
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

            Application.Run(new Form_login());
            //Application.Run(new Form_Master());
            //Application.Run(new FormXe());
            //Application.Run(new Form_Driver());
            //Application.Run(new Form_lichxe());
            //Application.Run(new Form_Action());

        }
    }
}
