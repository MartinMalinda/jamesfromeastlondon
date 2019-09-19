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
            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            canvas.Width = 500;
            canvas.Height = 500;
            foxDraw.SetBackgroundColor(Colors.LightYellow);

            for (int i = 100; i <= 200; i+=50)
            {
                DrawSquare(foxDraw, i, i);
            }
        }

        public static void DrawSquare(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetFillColor(Colors.Transparent);
            foxDraw.SetStrokeColor(Colors.Orange);
            foxDraw.SetStrokeThicknes(2);
            foxDraw.DrawRectangle(250 - x/2, 250 - y/2, x, y); // 250 = half of canvas size
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}