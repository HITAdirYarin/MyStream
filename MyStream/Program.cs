using System;
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
        /// </summary>
        [STAThread]
        static void Main()
        {
           // ContentController.addMovies();
            ContentHendler.loadMovies();
            UserHendler.getUserCount();
            UserHendler.loadUser();
            //ContentController.addReviews("Fast and Furious 9", "Amazing!");
            //ContentController.addReviews("Fast and Furious 9", "wow!");
            //ContentController.addReviews("Fast and Furious 9", "like it!");
            string review = Content._contents["Fast and Furious 9"]._review[0];
            MessageBox.Show(review);
            review = Content._contents["Fast and Furious 9"]._review[1];
            MessageBox.Show(review);
            review = Content._contents["Fast and Furious 9"]._review[2];
            MessageBox.Show(review);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
    }
}
