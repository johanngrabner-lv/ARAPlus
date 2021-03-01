using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace ARAPlus.WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            StichprobenViewModel vm = new StichprobenViewModel();
            vm.Stichproben = _context.Stichprobe.ToList();
            vm.AnzahlGefahrengut = vm.Stichproben.Where(s => s.Gefahrengut == true).Count();
            vm.LetztAbgabe = vm.Stichproben.Max(s => s.Abgabedatum);

            return View(vm);
        }
    }
}
