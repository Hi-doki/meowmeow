using System.Media;
using System.Drawing;
using System.Drawing.Imaging;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void pp(){
    Rectangle size = Screen.GetBounds(Point.Empty);
    Bitmap cBitmap = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
    Rectangle cRectangle = Screen.AllScreens[0].Bounds;
    Graphics cGraphics = Graphics.FromImage(cBitmap);
    cGraphics.CopyFromScreen(cRectangle.Left, cRectangle.Top, 0, 0, cRectangle.Size);
    cBitmap.Save(@"uwu.png", System.Drawing.Imaging.ImageFormat.Jpeg);
}
pp();
Console.ReadLine();