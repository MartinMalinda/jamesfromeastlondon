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
            // Line play
            // https://github.com/green-fox-academy/chama-retros-syllabus/blob/master/project/drawing/r1.png

            canvas.Width = 300;
            canvas.Height = 300;
            line(foxDraw);
        }
           
        public void line(FoxDraw foxdraw)
        {
            foxdraw.SetStrokeThicknes(1);

            for (int i = 20; i < 300; i += 20) // Lines Top Left
            {
                var startPoint = new Point(0, i);
                var endPoint = new Point(i, 300);
                foxdraw.SetStrokeColor(Colors.Green);
                foxdraw.DrawLine(startPoint, endPoint);
            }
            for (int i = 20; i < 300; i += 20) // Lines Top Right
            {
                var startPointTwo = new Point(i, 0);
                var endPointTwo = new Point(300, i);
                foxdraw.SetStrokeColor(Colors.Purple);
                foxdraw.DrawLine(startPointTwo, endPointTwo);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}