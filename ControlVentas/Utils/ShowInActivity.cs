using ControlVentas.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Utils
{
    public static class ShowInActivity
    {
        static ShowInActivityView showInActivityView;
        static Stopwatch watch;
        public static void Show(string message)
        {
            //singleton
            if (showInActivityView == null)
                showInActivityView = new ShowInActivityView();
            showInActivityView.Message = message;
            if (!showInActivityView.Visible)
            {
                watch = System.Diagnostics.Stopwatch.StartNew();
                showInActivityView.Show();
            }
        }
        public static void Hide()
        {
            showInActivityView.Hide();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Debug.Print($"Tiempo de ejecución: {elapsedMs} ms");
        }
    }
}
