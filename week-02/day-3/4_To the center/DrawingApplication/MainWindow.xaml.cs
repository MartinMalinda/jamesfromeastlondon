using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.

            canvas.Width = 500;
            canvas.Height = 500;
            foxDraw.SetBackgroundColor(Colors.Yellow);

            DrawLine(foxDraw);
        }

        public static void DrawLine(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeThicknes(2);
            foxDraw.SetStrokeColor(Colors.Green);
            var startPoint = new Point(0, 0);
            var endPoint = new Point(250, 250);

            for (int i = 0; i <= 500; i+=250)
            {
                startPoint = new Point(i, 0);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
