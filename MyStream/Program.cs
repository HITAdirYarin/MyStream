﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStream
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// this program run MyStream - a streaming application
        /// </summary>
        [STAThread]
        static void Main()
        {
            ContentHendler.loadPod();
            ContentHendler.loadMovies();
            ContentHendler.loadSeries();
            UserHendler.getUserCount();
            UserHendler.loadUser();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
    }
}
