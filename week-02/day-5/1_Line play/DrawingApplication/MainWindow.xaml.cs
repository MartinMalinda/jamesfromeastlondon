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

            canvas.Width = 150;
            canvas.Height = 150;
            foxDraw.SetBackgroundColor(Colors.Pink);
            line(foxDraw);
        }
           
        public void line(FoxDraw foxdraw)
        {
            foxdraw.SetStrokeThicknes(1);
            foxdraw.SetStrokeColor(Colors.Green);

            for (int i = 10; i < 150; i+=10)
            {
                var startPoint = new Point (0, i);
                var endPoint = new Point (i, 150);
                foxdraw.DrawLine(startPoint, endPoint);
            }
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
