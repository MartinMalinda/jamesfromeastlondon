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
            // Draw a box that has different colored lines on each edge.

            DrawBox(foxDraw);
        }

        public static void DrawBox(FoxDraw foxDraw)
        {
            var dict = new Dictionary<Color, List<int>>()
            {
                // Horizontal
                {Colors.DarkRed, new List<int> () {20, 20, 120, 20}},
                {Colors.LimeGreen, new List<int> () {70, 70, 170, 70}},
                {Colors.CadetBlue, new List<int> () {20, 120, 120, 120}},
                {Colors.Gray, new List<int> () {70, 170, 170, 170}},

                // Vertical
                {Colors.Gold, new List<int> () {20, 20, 20, 120}},
                {Colors.HotPink, new List<int> () {70, 70, 70, 170}},
                {Colors.Orange, new List<int> () {120, 20, 120, 120}},
                {Colors.Turquoise, new List<int> () {170, 70, 170, 170}},

                // Diagonal
                {Colors.Violet, new List<int> {20, 20, 70, 70}},
                {Colors.Yellow, new List<int> {120, 20, 170, 70}},
                {Colors.Tan, new List<int> {20, 120, 70, 170}},
                {Colors.Black, new List<int> {120, 120, 170,170}}
            };

            foreach (var line in dict)
            {
                foxDraw.SetStrokeColor(line.Key);
                foxDraw.SetStrokeThicknes(3);
                foxDraw.DrawLine(line.Value[0], line.Value[1], line.Value[2], line.Value[3]);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
