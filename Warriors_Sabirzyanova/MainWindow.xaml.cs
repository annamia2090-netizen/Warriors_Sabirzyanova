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
using Warriors_Sabirzyanova.Classes;

namespace Warriors_Sabirzyanova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LightWarrior LightWarrior = new LightWarrior(100, 0.8);
        public HeavyWarrior HeavyWarrior = new HeavyWarrior(100, 0.5);

        public MainWindow()
        {
            InitializeComponent();
            UserInfoWarriors();
        }

        public void UserInfoWarriors()
        {
            lightHealth.Content = "Жизненные показатели: " + LightWarrior.Health;
            heavyHealth.Content = "Жизненные показатели: " + HeavyWarrior.Health;
        }

        private void AttackLightWarrior(object sender, MouseButtonEventArgs e)
        {
            if (LightWarrior.Health <= 0)
            {
                MessageBox.Show("Воин в легких доспехах побежден!");
                return;
            }
            LightWarrior.TakeDamage(20);
            UserInfoWarriors();
        }

        private void AttackHeavyWarrior(object sender, MouseButtonEventArgs e)
        {
            if (HeavyWarrior.Health <= 0)
            {
                MessageBox.Show("Воин в тяжелых доспехах побежден!");
                return;
            }
            HeavyWarrior.TakeDamage(20);
            UserInfoWarriors();
        }
    }
}
