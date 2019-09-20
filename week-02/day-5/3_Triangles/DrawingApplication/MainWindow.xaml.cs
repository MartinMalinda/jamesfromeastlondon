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
            // Triangle
            // https://github.com/green-fox-academy/chama-retros-syllabus/blob/master/project/drawing/r5.png

            canvas.Width = 200;
            canvas.Height = 200;
            foxDraw.SetBackgroundColor(Colors.WhiteSmoke);
            triangle(foxDraw, 10);
        }
           
        public void triangle(FoxDraw foxdraw, int lineLength)
        {
            foxdraw.SetStrokeThicknes(1);
            foxdraw.SetStrokeColor(Colors.Black);

            for (int i = 0; i < 200; i += 10) // Lines Horizontal
            {
                var startPoint = new Point(95 - i/2 , lineLength + i);
                var endPoint = new Point(105 + i/2, lineLength + i);
                foxdraw.DrawLine(startPoint, endPoint);
            }
            for (int i = 0; i < 200; i += 10) // Lines Diagonal Left
            {
                var startPoint = new Point(i, 200);
                var endPoint = new Point(100 + i/2, i);
                foxdraw.DrawLine(startPoint, endPoint);
            }
            for (int i = 0; i <= 200; i += 10) // Lines Diagonal Right
            {
                var startPoint = new Point(i, 200);
                var endPoint = new Point(0 + i/2, 200 - i);
                foxdraw.DrawLine(startPoint, endPoint);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}