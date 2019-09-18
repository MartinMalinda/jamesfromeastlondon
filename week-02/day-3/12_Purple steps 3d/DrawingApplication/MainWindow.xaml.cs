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
            // Reproduce this:
            // [https://github.com/green-fox-academy/chama-cs-prg-syllabus/blob/master/workshop/drawing/assets/r4.png]

            DrawLine(foxDraw);
        }

        public static void DrawLine(FoxDraw foxDraw)
        {
            foxDraw.SetFillColor(Colors.Purple);
            foxDraw.SetStrokeThicknes(1);
            int square = 4;
            for (int shape = 0; shape < 6; shape++)
            {
                square += square;
                foxDraw.DrawRectangle(square, square, square, square);            
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}