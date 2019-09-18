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
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.

            canvas.Width = 400;
            canvas.Height = 400;
            foxDraw.SetBackgroundColor(Colors.Yellow);

            DrawLine(foxDraw);
        }

        public static void DrawLine(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 200, 400, 200);

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(200, 0, 200, 400);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
