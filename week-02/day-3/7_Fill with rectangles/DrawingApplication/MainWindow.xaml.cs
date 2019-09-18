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
            // draw four different size and color rectangles.
            // avoid code duplication.

            DrawLine(foxDraw);
        }

        public static void DrawLine(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeThicknes(0);
            for (int shape = 0; shape < 40; shape+=10)
            {
                if (shape == 0)
                {
                    foxDraw.SetFillColor(Colors.Pink);
                }
                else if (shape == 10)
                {
                    foxDraw.SetFillColor(Colors.Red);
                }
                else if (shape == 20)
                {
                    foxDraw.SetFillColor(Colors.Blue);
                }
                else
                {
                    foxDraw.SetFillColor(Colors.Green);
                }
                foxDraw.DrawRectangle(shape + shape * 2, shape + 50, shape + 5, shape + 5);            
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}