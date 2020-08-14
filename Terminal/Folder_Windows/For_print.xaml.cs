using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Printing;
using QRCoder;
using System.IO;
using System.Drawing;

namespace Terminal.Folder_Windows
{
    /// <summary>
    /// Логика взаимодействия для For_print.xaml
    /// </summary>
    public partial class For_print : Window
    {
        string Profes="";
        string Ochered;
        string Qr_image_text;
        public For_print(string Profes,string Ochered,string Qr_image_text)
        {
            InitializeComponent();
            this.Profes = Profes;
            this.Ochered = Ochered;
            this.Qr_image_text = Qr_image_text;
            date(); 
        }
        private void date()
        {
            DateTime dt = DateTime.Now;
            Data_txt.Text = dt.ToShortDateString().ToString() + "  " + dt.ToShortTimeString().ToString();
            Profesia_text.Text = Profes;
            Ochered_Number.Text = Ochered;
            QrEnCoder(Qr_Image, Qr_image_text);
        }
        public void Check_Print()
        {         
                PrintDialog printDialog = new PrintDialog();
            //if (printDialog.ShowDialog() == true)
            //{
                //grd.LayoutTransform = new ScaleTransform(5, 5);

                grd.Measure(new System.Windows.Size(printDialog.PrintableAreaWidth, double.PositiveInfinity));

                grd.Arrange(new Rect(grd.DesiredSize));

                grd.UpdateLayout();

                printDialog.PrintTicket.PageMediaSize = new PageMediaSize(printDialog.PrintableAreaWidth, grd.ActualHeight);

                printDialog.PrintQueue = LocalPrintServer.GetDefaultPrintQueue();

                printDialog.PrintVisual(grd, "Check");

        //}
    }
        private ImageSource BitmapToImageSourse(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage;
            }

        }
        private void QrEnCoder(System.Windows.Controls.Image img, string txt)
        {
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(txt, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap bitmap = qRCode.GetGraphic(20);
            img.Source = BitmapToImageSourse(bitmap);
        }
    }
}
