using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateRD();
        }
        public static void CreateRD()
        {
            ResourceDictionary resourceDictionary = new ResourceDictionary();
            Trace.WriteLine("----------------");
            Trace.WriteLine(resourceDictionary.Source);
            Trace.WriteLine("----------------");
        }

        public static void MyThemeChange(string newTheme)
        {
            // определяем путь к файлу ресурсов
            var uri = new Uri("Theme\\" + newTheme + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            MyThemeChange("Dictionary" + TB.Text);
        }
    }
}
