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
            // [https://github.com/green-fox-academy/chama-cs-prg-syllabus/blob/master/workshop/drawing/assets/r3.png]

            DrawLine(foxDraw);
        }

        public static void DrawLine(FoxDraw foxDraw)
        {
            foxDraw.SetFillColor(Colors.Purple);
            foxDraw.SetStrokeThicknes(1);
            int square = 10;
            for (int shape = 0; shape < 20; shape++)
            {
                square += 10;
                foxDraw.DrawRectangle(square, square, 10, 10);            
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}