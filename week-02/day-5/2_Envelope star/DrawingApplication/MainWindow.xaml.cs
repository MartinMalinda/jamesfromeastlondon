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
            // Envelope star
            // https://github.com/green-fox-academy/chama-retros-syllabus/blob/master/project/drawing/r2.png

            canvas.Width = 300;
            canvas.Height = 300;
            foxDraw.SetBackgroundColor(Colors.WhiteSmoke);
            line(foxDraw, 150);
        }
           
        public void line(FoxDraw foxdraw, int quarter)
        {
            foxdraw.SetStrokeThicknes(1);
            foxdraw.SetStrokeColor(Colors.Green);

            for (int i = 10; i < 150; i += 10) // Lines Top Right
            {
                var startPoint = new Point(quarter, i);
                var endPoint = new Point(quarter + i, quarter);
                foxdraw.DrawLine(startPoint, endPoint);
            }
            for (int i = 10; i < 150; i += 10) // Lines Top Left
            {
                var startPoint = new Point(quarter, i);
                var endPoint = new Point(quarter - i, quarter);
                foxdraw.DrawLine(startPoint, endPoint);
            }
            for (int i = 10; i < 150; i += 10) // Bottom Right
            {
                var startPoint = new Point(quarter + i, quarter);
                var endPoint = new Point(quarter, 300 - i);
                foxdraw.DrawLine(startPoint, endPoint);
            }
            for (int i = 10; i < 150; i += 10) // Bottom Left
            {
                var startPoint = new Point(i, quarter);
                var endPoint = new Point(quarter, quarter + i);
                foxdraw.DrawLine(startPoint, endPoint);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
