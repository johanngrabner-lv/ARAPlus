using ARAPlus.AspWebMitMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

namespace ARAPlus.WpfDemoNet5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //DbContextOptions<StichprobenContext> options=new DbContextOptions<StichprobenContext>()
            StichprobenContext _context = new StichprobenContext();

            StichprobenViewModel vm = new StichprobenViewModel();
            vm.Stichproben = _context.Stichprobe.ToList();
            vm.AnzahlGefahrengut = vm.Stichproben.Where(s => s.Gefahrengut == true).Count();
            vm.LetztAbgabe = vm.Stichproben.Max(s => s.Abgabedatum);

            this.DataContext = vm;
        }
    }
}
