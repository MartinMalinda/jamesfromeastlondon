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
            // Draw a green 10x10 square to the canvas' center.

            canvas.Width = 100;
            canvas.Height = 100;
            foxDraw.SetBackgroundColor(Colors.Yellow);

            DrawLine(foxDraw);
        }

        public static void DrawLine(FoxDraw foxDraw)
        {
            foxDraw.SetFillColor(Colors.Green);
            foxDraw.SetStrokeThicknes(0);
            foxDraw.DrawRectangle(45, 45, 10, 10);            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
