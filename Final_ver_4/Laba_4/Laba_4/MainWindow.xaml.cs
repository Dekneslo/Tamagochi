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
using Pet_Lib4;
using static Pet_Lib4.Pet;

namespace Laba_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Pet1_Lib pet = new Pet1_Lib();
        Dog dog = new Dog();
        Cat cat = new Cat();
        Pet pet = new Pet();
        //Pet1_Lib satiety1 = new Pet1_Lib();//Уровень сытости(проценты)
        //Random r = new Random();
        //int x;
        //int y;
        //int f;

        //string name;

        private void BPET_Click(object sender, RoutedEventArgs e)
        {

            pet.Weight = Convert.ToInt32(TBPet_W.Text);
            pet.Satiety = Convert.ToInt32(TBPet_S.Text);

            pet.Name = TBPet_W.Text;

            PG_PETW.Value = pet.Weight;
            PG_PETS.Value = pet.Satiety;

            PG_PETW.Maximum = Convert.ToDouble(PG_PETW_max.Text);
            PG_PETS.Maximum = Convert.ToDouble(PG_PETS_max.Text);
            L1.Content += ""+TBPet_W.Text;
            L2.Content += ""+TBPet_S.Text;

            BPET.IsEnabled = false;
        }

        private void BDOG_Click(object sender, RoutedEventArgs e)
        {

            dog.Weight = Convert.ToInt32(TBDog_W.Text);
            dog.Satiety = Convert.ToInt32(TBDog_S.Text);
            dog.Mood = Convert.ToInt32(TBDog_M.Text);

            dog.Name = TBDOG_N.Text;

            PG_DOGW.Value = dog.Weight;
            PG_DOGS.Value = dog.Satiety;
            PG_DOGM.Value = dog.Mood;

            PG_DOGW.Maximum = Convert.ToDouble(PG_DOGW_max.Text);
            PG_DOGS.Maximum = Convert.ToDouble(PG_DOGS_max.Text);
            PG_DOGM.Maximum = Convert.ToDouble(PG_DOGM_max.Text);

            L3.Content += "" + TBDog_W.Text;
            L4.Content += "" + TBDog_S.Text;
            L5.Content += "" + TBDog_M.Text;

            BDOG.IsEnabled = false;
        }

        private void BCAT_Click(object sender, RoutedEventArgs e)
        {

            cat.Weight = Convert.ToInt32(TBCat_W.Text);
            cat.Mood = Convert.ToInt32(TBCat_M.Text);

            cat.Name = TBCAT_N.Text;

            PG_CATW.Value = cat.Weight;
            PG_CATM.Value = cat.Mood;

            PG_CATW.Maximum = Convert.ToDouble(PG_CATW_max.Text);
            PG_CATM.Maximum = Convert.ToDouble(PG_CATM_max.Text);

            L6.Content += "" + TBCat_W.Text;
            L7.Content += "" + TBCat_M.Text;

            BCAT.IsEnabled = false;
        }

        private void BRES_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(TBPet_W.Text);
            int y = Convert.ToInt32(TBPet_S.Text);
            int f = Convert.ToInt32(TBDog_W.Text);
            int a = Convert.ToInt32(TBDog_S.Text);
            int b = Convert.ToInt32(TBDog_M.Text);
            int c = Convert.ToInt32(TBCat_W.Text);
            int d = Convert.ToInt32(TBCat_M.Text);
            pet.Feed(x, y, x);
            dog.Feed(f, a, b);
            cat.Feed(d, c, c);
            PG_PETW.Value = pet.Weight;
            PG_PETS.Value = pet.Satiety;
            PG_DOGM.Value = dog.Mood;
            PG_DOGW.Value = dog.Weight;
            PG_DOGS.Value = dog.Satiety;
            PG_CATM.Value = cat.Mood;
            PG_CATW.Value = cat.Weight;
           
            TBPet_W.Text = "" + (PG_PETW.Value);
            TBPet_S.Text = "" + (PG_PETS.Value);
            TBDog_M.Text = "" + (PG_DOGM.Value);
            TBDog_W.Text = "" + (PG_DOGW.Value);
            TBDog_S.Text = "" + (PG_DOGS.Value);
            TBCat_M.Text = "" + (PG_CATM.Value);
            TBCat_W.Text = "" + (PG_CATW.Value);

        }
    }
}
