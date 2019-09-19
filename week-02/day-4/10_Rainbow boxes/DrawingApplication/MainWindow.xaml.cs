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
            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).

            canvas.Width = 700;
            canvas.Height = 700;

            Color[] colorsFill =
            {
                Colors.Red,
                Colors.Orange,
                Colors.Green,
                Colors.Yellow,
                Colors.Blue,
                Colors.Indigo,
                Colors.Violet,
            };

            int size = 700;
            int CalculationOne = size/colorsFill.Length;
            int CalculationTwo = CalculationOne / 2;
            int position = 0;

            foreach (var color in colorsFill)
            {
                foxDraw.SetStrokeThicknes(0);
                foxDraw.SetFillColor(color);
                foxDraw.DrawRectangle(position, position, size, size);
                size -= CalculationOne;
                position += CalculationTwo;
            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}