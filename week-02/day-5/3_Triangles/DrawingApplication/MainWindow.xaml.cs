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

            Triangle(foxDraw, canvas, 10);
        }
           
        public void Triangle(FoxDraw foxdraw, Canvas canvas, int lineLength)
        {
            foxdraw.SetStrokeThicknes(1);
            foxdraw.SetStrokeColor(Colors.Black);

            for (int i = 0; i < 200; i += 10) // Lines Horizontal
            {
                var startPoint = new Point(95 - i/2 , lineLength + i);
                var endPoint = new Point(105 + i/2, lineLength + i);
                foxdraw.DrawLine(startPoint, endPoint);
            }

            for (int i = 0; i < 200; i += 10) // Lines Diagonal | Left to Right
            {
                var startPoint = new Point(i, canvas.Height);
                var endPoint = new Point(100 + i/2, i);
                foxdraw.DrawLine(startPoint, endPoint);
            }

            for (int i = 0; i <= 200; i += 10) // Lines Diagonal | Right to Left
            {
                var startPoint = new Point(i, canvas.Height);
                var endPoint = new Point(0 + i/2, canvas.Height - i);
                foxdraw.DrawLine(startPoint, endPoint);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
