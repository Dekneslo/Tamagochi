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
        Random r = new Random();
        int x;
        int y;
        int z;
        int f;
        int a;
        int b;
        int c;
        int d;
        int g;
        int h;
        int i;
        int j;
        int k;
        int l;
        int m;
        int n;

        string name;

        private void BSafePET_Click(object sender, RoutedEventArgs e)
        {
            pet.Weight = Convert.ToInt32(TBPet_W.Text);
            pet.Mood = Convert.ToInt32(TBPet_M.Text);
            pet.Satiety = Convert.ToInt32(TBPet_S.Text);
            pet.Forces = Convert.ToInt32(TBPet_F.Text);

            pet.Name = TBPET_N.Text;

            PG_PETW.Value = pet.Weight;
            PG_PETM.Value = pet.Mood;
            PG_PETS.Value = pet.Satiety;
            PG_PETF.Value = pet.Forces;

            PG_PETW.Maximum = Convert.ToDouble(PG_PETWMax.Text);
            PG_PETM.Maximum = Convert.ToDouble(PG_PETMax.Text);
            PG_PETS.Maximum = Convert.ToDouble(PG_PETMax.Text);
            PG_PETF.Maximum = Convert.ToDouble(PG_PETMax.Text);


            a = Convert.ToInt32(TBPet_W.Text);
            b = Convert.ToInt32(TBPet_M.Text);
            c = Convert.ToInt32(TBPet_S.Text);
            d = Convert.ToInt32(TBPet_F.Text);

            L1.Content += "" + a;
            L2.Content += "" + b;
            L3.Content += "" + c;
            L4.Content += "" + d;

            BSafePET.IsEnabled = false;
        }

        private void BSafeDOG_Click(object sender, RoutedEventArgs e)
        {
            dog.Weight = Convert.ToInt32(TBDog_W.Text);
            dog.Mood = Convert.ToInt32(TBDog_M.Text);
            dog.Satiety = Convert.ToInt32(TBDog_S.Text);
            dog.Forces = Convert.ToInt32(TBDog_F.Text);

            dog.Name = TBDOG_N.Text;

            PG_DOGW.Value = dog.Weight;
            PG_DOGM.Value = dog.Mood;
            PG_DOGS.Value = dog.Satiety;
            PG_DOGF.Value = dog.Forces;

            PG_DOGW.Maximum = Convert.ToDouble(PG_DOGWMax.Text);
            PG_DOGM.Maximum = Convert.ToDouble(PG_DOGMax.Text);
            PG_DOGS.Maximum = Convert.ToDouble(PG_DOGMax.Text);
            PG_DOGF.Maximum = Convert.ToDouble(PG_DOGMax.Text);

            g = Convert.ToInt32(TBDog_W.Text);
            h = Convert.ToInt32(TBDog_M.Text);
            i = Convert.ToInt32(TBDog_S.Text);
            j = Convert.ToInt32(TBDog_F.Text);

            L5.Content += "" + g;
            L6.Content += "" + h;
            L7.Content += "" + i;
            L8.Content += "" + j;

            BSafeDOG.IsEnabled = false;
        }

        private void BSafeCAT_Click(object sender, RoutedEventArgs e)
        {
            cat.Weight = Convert.ToInt32(TBCat_W.Text);
            cat.Mood = Convert.ToInt32(TBCat_M.Text);
            cat.Satiety = Convert.ToInt32(TBCat_S.Text);
            cat.Forces = Convert.ToInt32(TBCat_F.Text);

            cat.Name = TBCAT_N.Text;

            PG_CATW.Value = cat.Weight;
            PG_CATM.Value = cat.Mood;
            PG_CATS.Value = cat.Satiety;
            PG_CATF.Value = cat.Forces;

            PG_CATW.Maximum = Convert.ToDouble(PG_CATWMax.Text);
            PG_CATM.Maximum = Convert.ToDouble(PG_CATMax.Text);
            PG_CATS.Maximum = Convert.ToDouble(PG_CATMax.Text);
            PG_CATF.Maximum = Convert.ToDouble(PG_CATMax.Text);

            k = Convert.ToInt32(TBCat_W.Text);
            l = Convert.ToInt32(TBCat_M.Text);
            m = Convert.ToInt32(TBCat_S.Text);
            n = Convert.ToInt32(TBCat_F.Text);

            L9.Content += "" + k;
            L10.Content += "" + l;
            L11.Content += "" + m;
            L12.Content += "" + n;

            BSafeCAT.IsEnabled = false;
        }
        private void BCaressPET_Click_1(object sender, RoutedEventArgs e)
        {
                int x = Convert.ToInt32(TBPet_M.Text);
                int z = Convert.ToInt32(TBPet_F.Text);

                pet.Caress(x, z);

                PG_PETM.Value = pet.Mood;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + (PG_PETM.Value);
                TBPet_F.Text = "" + (PG_PETF.Value);

                pet.Test(x, y, z);//////проверка метод!

                if (PG_PETM.Value != 0)
                {
                    PG_PETM.Value += 0;
                }
                else
                {
                    MessageBox.Show("ты убиль его...");
                }
                if (PG_PETF.Value != 0)
                {
                    PG_PETF.Value += 0;
                }
                else
                {
                    MessageBox.Show("ты убиль его...");
                }
        }
        private void BPlayPET1_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(TBPet_M.Text);
            int y = Convert.ToInt32(TBPet_S.Text);
            int z = Convert.ToInt32(TBPet_F.Text);

            pet.Play(x, y, z);

            PG_PETM.Value = pet.Mood;
            PG_PETS.Value = pet.Satiety;
            PG_PETF.Value = pet.Forces;

            TBPet_M.Text = "" + (PG_PETM.Value);
            TBPet_S.Text = "" + (PG_PETS.Value);
            TBPet_F.Text = "" + (PG_PETF.Value);

            if (PG_PETM.Value != 0)
            {
                PG_PETM.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_PETS.Value != 0)
            {
                PG_PETS.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_PETF.Value != 0)
            {
                PG_PETF.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }
        private void BFeedPET1_Click(object sender, RoutedEventArgs e)
        {
            int f = Convert.ToInt32(TBPet_W.Text);
            int y = Convert.ToInt32(TBPet_S.Text);

            pet.Feed(f, y);

            PG_PETW.Value = pet.Weight;
            PG_PETS.Value = pet.Satiety;

            TBPet_W.Text = "" + (PG_PETW.Value);
            TBPet_S.Text = "" + (PG_PETS.Value);


            if (PG_PETW.Value != 0)
            {
                PG_PETW.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_PETS.Value != 0)
            {
                PG_PETS.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }
        private void BTrainPET1_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(TBPet_M.Text);
            int y = Convert.ToInt32(TBPet_S.Text);
            int z = Convert.ToInt32(TBPet_F.Text);

            pet.Train(x, y, z);

            PG_PETM.Value = pet.Mood;
            PG_PETS.Value = pet.Satiety;
            PG_PETF.Value = pet.Forces;

            TBPet_M.Text = "" + (PG_PETM.Value);
            TBPet_S.Text = "" + (PG_PETS.Value);
            TBPet_F.Text = "" + (PG_PETF.Value);

            if (PG_PETM.Value != 0)
            {
                PG_PETM.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_PETS.Value != 0)
            {
                PG_PETS.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_PETF.Value != 0)
            {
                PG_PETF.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }
        private void BCaressDOG1_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(TBDog_M.Text);
            int z = Convert.ToInt32(TBDog_F.Text);

            dog.Caress(x, z);

            PG_DOGM.Value = dog.Mood;
            PG_DOGF.Value = dog.Forces;

            TBDog_M.Text = "" + (PG_DOGM.Value);
            TBDog_F.Text = "" + (PG_DOGF.Value);

            if (PG_DOGM.Value != 0)
            {
                PG_DOGM.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_DOGF.Value != 0)
            {
                PG_DOGF.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }
        private void BPlayDOG2_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(TBDog_M.Text);
            int y = Convert.ToInt32(TBDog_S.Text);
            int z = Convert.ToInt32(TBDog_F.Text);

            dog.Play(x, y, z);

            PG_DOGM.Value = dog.Mood;
            PG_DOGS.Value = dog.Satiety;
            PG_DOGF.Value = dog.Forces;

            TBDog_M.Text = "" + (PG_DOGM.Value);
            TBDog_S.Text = "" + (PG_DOGS.Value);
            TBDog_F.Text = "" + (PG_DOGF.Value);

            if (PG_DOGM.Value != 0)
            {
                PG_DOGM.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_DOGS.Value != 0)
            {
                PG_DOGS.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_DOGF.Value != 0)
            {
                PG_DOGF.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }
        private void BFeedDOG_Click(object sender, RoutedEventArgs e)
        {
            int f = Convert.ToInt32(TBDog_W.Text);
            int y = Convert.ToInt32(TBDog_S.Text);

            dog.Feed(f, y);

            PG_DOGW.Value = dog.Weight;
            PG_DOGS.Value = dog.Satiety;

            TBDog_W.Text = "" + (PG_DOGW.Value);
            TBDog_S.Text = "" + (PG_DOGS.Value);

            if (PG_DOGW.Value != 0)
            {
                PG_DOGW.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_DOGS.Value != 0)
            {
                PG_DOGS.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }

        private void BTrainDOG1_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(TBDog_M.Text);
            int y = Convert.ToInt32(TBDog_S.Text);
            int z = Convert.ToInt32(TBDog_F.Text);

            dog.Train(x, y, z);

            PG_DOGM.Value = dog.Mood;
            PG_DOGS.Value = dog.Satiety;
            PG_DOGF.Value = dog.Forces;

            TBDog_M.Text = "" + (PG_DOGM.Value);
            TBDog_S.Text = "" + (PG_DOGS.Value);
            TBDog_F.Text = "" + (PG_DOGF.Value);

            if (PG_DOGM.Value != 0)
            {
                PG_DOGM.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_DOGS.Value != 0)
            {
                PG_DOGS.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_DOGF.Value != 0)
            {
                PG_DOGF.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }

        private void BCaressCAT1_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(TBCat_M.Text);
            int z = Convert.ToInt32(TBCat_F.Text);

            cat.Caress(x, z);

            PG_CATM.Value = cat.Mood;
            PG_CATF.Value = cat.Forces;

            TBCat_M.Text = "" + (PG_CATM.Value);
            TBCat_F.Text = "" + (PG_CATF.Value);

            if (PG_CATM.Value != 0)
            {
                PG_CATM.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_CATF.Value != 0)
            {
                PG_CATF.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }

        private void BPlayCAT1_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(TBCat_M.Text);
            int y = Convert.ToInt32(TBCat_S.Text);
            int z = Convert.ToInt32(TBCat_F.Text);

            cat.Play(x, y, z);

            PG_CATM.Value = cat.Mood;
            PG_CATS.Value = cat.Satiety;
            PG_CATF.Value = cat.Forces;

            TBCat_M.Text = "" + (PG_CATM.Value);
            TBCat_S.Text = "" + (PG_CATS.Value);
            TBCat_F.Text = "" + (PG_CATF.Value);

            if (PG_CATM.Value != 0)
            {
                PG_CATM.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_CATS.Value != 0)
            {
                PG_CATS.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_CATF.Value != 0)
            {
                PG_CATF.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }

        private void BFeedCAT1_Click(object sender, RoutedEventArgs e)
        {
            int f = Convert.ToInt32(TBCat_W.Text);
            int y = Convert.ToInt32(TBCat_S.Text);

            cat.Feed(f, y);

            PG_CATW.Value = cat.Weight;
            PG_CATS.Value = cat.Satiety;

            TBCat_W.Text = "" + (PG_CATW.Value);
            TBCat_S.Text = "" + (PG_CATS.Value);

            if (PG_CATW.Value != 0)
            {
                PG_CATW.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_CATS.Value != 0)
            {
                PG_CATS.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }

        private void BTrainCAT1_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(TBCat_M.Text);
            int y = Convert.ToInt32(TBCat_S.Text);
            int z = Convert.ToInt32(TBCat_F.Text);

            cat.Train(x, y, z);

            PG_CATM.Value = cat.Mood;
            PG_CATS.Value = cat.Satiety;
            PG_CATF.Value = cat.Forces;

            TBCat_M.Text = "" + (PG_CATM.Value);
            TBCat_S.Text = "" + (PG_CATS.Value);
            TBCat_F.Text = "" + (PG_CATF.Value);

            if (PG_CATM.Value != 0)
            {
                PG_CATM.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_CATS.Value != 0)
            {
                PG_CATS.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
            if (PG_CATF.Value != 0)
            {
                PG_CATF.Value += 0;
            }
            else
            {
                MessageBox.Show("ты убиль его...");
            }
        }

        private void BPetRelife1_Click(object sender, RoutedEventArgs e)
        {
            pet = new Pet();

            BSafePET.IsEnabled = true;

            TBPet_W.Text = Convert.ToString(a);
            TBPet_M.Text = Convert.ToString(b);
            TBPet_S.Text = Convert.ToString(c);
            TBPet_F.Text = Convert.ToString(d);


            int f = Convert.ToInt32(PG_PETW.Value);
            int x = Convert.ToInt32(PG_PETM.Value);
            int y = Convert.ToInt32(PG_PETS.Value);
            int z = Convert.ToInt32(PG_PETF.Value);
        }

        private void BDogRelife1_Click(object sender, RoutedEventArgs e)
        {
            dog = new Dog();

            BSafeDOG.IsEnabled = true;

            TBDog_W.Text = Convert.ToString(g);
            TBDog_M.Text = Convert.ToString(h);
            TBDog_S.Text = Convert.ToString(i);
            TBDog_F.Text = Convert.ToString(j);

            int f = Convert.ToInt32(PG_DOGW.Value);
            int x = Convert.ToInt32(PG_DOGM.Value);
            int y = Convert.ToInt32(PG_DOGS.Value);
            int z = Convert.ToInt32(PG_DOGF.Value);
        }

        private void BCatRelife1_Click(object sender, RoutedEventArgs e)
        {
            cat = new Cat();

            BSafeCAT.IsEnabled = true;

            TBCat_W.Text = Convert.ToString(k);
            TBCat_M.Text = Convert.ToString(l);
            TBCat_S.Text = Convert.ToString(m);
            TBCat_F.Text = Convert.ToString(n);

            int f = Convert.ToInt32(PG_CATW.Value);
            int x = Convert.ToInt32(PG_CATM.Value);
            int y = Convert.ToInt32(PG_CATS.Value);
            int z = Convert.ToInt32(PG_CATF.Value);

        }

    }
}