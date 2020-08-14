using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Printing;
using System.Windows.Controls;
using System.Windows;

namespace Terminal.Folder_Class
{
    public static class Check_Print
    {
        public static void Print(Grid grd)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                //grd.LayoutTransform = new ScaleTransform(5, 5);

                grd.Measure(new System.Windows.Size(printDialog.PrintableAreaWidth, double.PositiveInfinity));

                grd.Arrange(new Rect(grd.DesiredSize));

                grd.UpdateLayout();

                printDialog.PrintTicket.PageMediaSize = new PageMediaSize(printDialog.PrintableAreaWidth, grd.ActualHeight);

                printDialog.PrintQueue = LocalPrintServer.GetDefaultPrintQueue();

                printDialog.PrintVisual(grd, "Check");

            }
        }
    }
}
