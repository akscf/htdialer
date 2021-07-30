using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * 
 * Copyright (C) AlexandrinKS
 * https://akscf.me/
 */
namespace HTDialer
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, @"htdialer_uyew763hd" );
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Sorry, another instance already working.");
            }
        }
    }
}
