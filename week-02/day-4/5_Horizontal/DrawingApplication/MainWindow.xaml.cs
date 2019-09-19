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
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.

            canvas.Width = 200;
            canvas.Height = 200;
            foxDraw.SetBackgroundColor(Colors.Yellow);

            for (int i = 0; i < 3; i++)
            {
                DrawLine(foxDraw, 10, i * 50 + 10 ); // Set x + y values for DrawLine method, y changes for every loop
            }
        }

        public static void DrawLine(FoxDraw foxDraw, int x, int y)
        {
            var startPoint = new Point(x, y); 
            var endPoint = new Point(x + 50, y); // End point makes the line 50 px long
            foxDraw.SetStrokeThicknes(2);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(startPoint, endPoint);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}