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
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            canvas.Width = 500;
            canvas.Height = 500;
            foxDraw.SetBackgroundColor(Colors.Yellow);

            DrawLine(foxDraw);
        }

        public static void DrawLine(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeThicknes(2);
            var startPoint = new Point(0, 0);
            var endPoint = new Point(500, 500);

            if (startPoint == new Point(0, 0))
            {
                foxDraw.SetStrokeColor(Colors.Green);
            }
            else
            {
                foxDraw.SetStrokeColor(Colors.Red);
            }
            foxDraw.DrawLine(startPoint, endPoint);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
