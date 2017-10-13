using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace v2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //TODO:这里的作用??LightningChart听说这个有用
        }





        //********************************************************************************
        private void button_Click(object sender, RoutedEventArgs e)
            {
            
            var openFileDialog = new Microsoft.Win32.OpenFileDialog()
                {
                    Filter = "二进制文件|*.bin*"
                };
                //限制文件打开类型的方法，格式是“文件名称|*.文件格式*”

                var result = openFileDialog.ShowDialog();
                if (result == true)
                {
                    this.textBox.Text = openFileDialog.FileName;
                 }
            }
        //*****************************************************************************        
        
         ///</summary>
        ///绘制线段但是不是在画布上实现这个 
        ///</summary>


        //TODO:把Drawing画在画布上
        protected void Drawing()
            {
                PathFigure myPathFigure = new PathFigure();
                myPathFigure.StartPoint = new Point(10, 50);

                LineSegment myLineSegment = new LineSegment();
                myLineSegment.Point = new Point(200, 70);

                PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
                myPathSegmentCollection.Add(myLineSegment);

                myPathFigure.Segments = myPathSegmentCollection;

                PathFigureCollection myPathFigureCollection = new PathFigureCollection();
                myPathFigureCollection.Add(myPathFigure);

                PathGeometry myPathGeometry = new PathGeometry();
                myPathGeometry.Figures = myPathFigureCollection;


                Path myPath = new Path();
                myPath.Stroke = Brushes.Black;
                myPath.StrokeThickness = 1;
                myPath.Data = myPathGeometry;

                // Add path shape to the UI.
                StackPanel mainPanel = new StackPanel();
                mainPanel.Children.Add(myPath);
                this.Content = mainPanel;

            }

        }
    }
