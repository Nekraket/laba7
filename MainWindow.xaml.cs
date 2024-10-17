using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Лабораторка7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void myButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Point cursorPosition = e.GetPosition(this);

            double newLeft = cursorPosition.X + 50;
            double newTop = cursorPosition.Y + 50;

            Storyboard buttonAnimation = (Storyboard)this.FindResource("ButtonAnimation");

            DoubleAnimation leftAnimation = (DoubleAnimation)buttonAnimation.Children[0];
            leftAnimation.To = newLeft;

            DoubleAnimation topAnimation = (DoubleAnimation)buttonAnimation.Children[1];
            topAnimation.To = newTop;

            buttonAnimation.Begin();
        }
    }
}