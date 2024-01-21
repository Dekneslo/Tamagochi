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
using Microsoft.SqlServer.Server;
using Pet_Lib6;
//using static Pet_Lib4.Pet;

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
        bool res1;
        bool res2;
        bool res3;
        bool res4;
        bool res5;
        bool res6;
        bool res7;
        bool res8;
        bool res9;
        bool res10;
        bool res11;
        bool res12;
        bool res13;
        bool res14;
        bool res15;
        bool res16;
        bool res17;
        bool res18;
        bool res19;
        bool res20;
        bool res21;
        bool res22;
        bool res23;
        bool res24;
        bool res25;
        bool res26;
        bool res27;
        bool res28;
        bool res29;
        bool res30;
        bool res31;
        bool res32;
        bool res33;
        bool res34;
        bool res35;
        bool res36;

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

            x = Convert.ToInt32(TBPet_M.Text);
            y = Convert.ToInt32(TBPet_S.Text);
            z = Convert.ToInt32(TBPet_F.Text);

           

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

            bool o=true;
                if (PG_PETM.Value != 0)
                {
                    PG_PETM.Value += 0;
                }
            else if (o)
            {
                    MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
                }
                if (PG_PETF.Value != 0)
                {
                    PG_PETF.Value += 0;
                }
            else if (o)
            {
                    MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
                }

            res1 = pet.Test1(b);
            bool w = true;
            if (TBPet_M.Visibility == Visibility.Visible)
            {
                if (res1 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res2 = pet.Test2(c);
            if (TBPet_S.Visibility == Visibility.Visible & w)
            {
                if (res2 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

            res3 = pet.Test3(d);
            if (TBPet_F.Visibility == Visibility.Visible & w)
            {
                if (res3 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
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

            bool o = true;
            if (PG_PETM.Value != 0)
            {
                PG_PETM.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_PETS.Value != 0)
            {
                PG_PETS.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }
            if (PG_PETF.Value != 0)
            {
                PG_PETF.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }

            res4 = pet.Test1(b);
            bool w = true;
            if (TBPet_M.Visibility == Visibility.Visible)
            {
                if (res4 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res5 = pet.Test2(c);
            if (TBPet_S.Visibility == Visibility.Visible & w)
            {
                if (res5 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res6 = pet.Test3(d);
            if (TBPet_F.Visibility == Visibility.Visible & w)
            {
                if (res6 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

        }
        private void BFeedPET1_Click(object sender, RoutedEventArgs e)
        {
            int f = Convert.ToInt32(TBPet_W.Text);
            int y = Convert.ToInt32(TBPet_S.Text);

            pet.Feed(f, y, f);

            PG_PETW.Value = pet.Weight;
            PG_PETS.Value = pet.Satiety;

            TBPet_W.Text = "" + (PG_PETW.Value);
            TBPet_S.Text = "" + (PG_PETS.Value);

            bool o = true;
            if (PG_PETW.Value != 0)
            {
                PG_PETW.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_PETS.Value != 0)
            {
                PG_PETS.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }

            res7 = pet.Test1(b);
            bool w = true;
            if (TBPet_M.Visibility == Visibility.Visible)
            {
                if (res7 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res8 = pet.Test2(c);
            if (TBPet_S.Visibility == Visibility.Visible & w)
            {
                if (res8 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res9 = pet.Test3(d);
            if (TBPet_F.Visibility == Visibility.Visible & w)
            {
                if (res9 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
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

            bool o = true;
            if (PG_PETM.Value != 0)
            {
                PG_PETM.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }
            if (PG_PETS.Value != 0)
            {
                PG_PETS.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_PETF.Value != 0)
            {
                PG_PETF.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }

            res10 = pet.Test1(b);
            bool w = true;
            if (TBPet_M.Visibility == Visibility.Visible)
            {
                if (res10 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res11 = pet.Test2(c);
            if (TBPet_S.Visibility == Visibility.Visible & w)
            {
                if (res11 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res12 = pet.Test3(d);
            if (TBPet_F.Visibility == Visibility.Visible & w)
            {
                if (res12 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
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

            bool o = true;
            if (PG_DOGM.Value != 0)
            {
                PG_DOGM.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_DOGF.Value != 0)
            {
                PG_DOGF.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }

            res13 = dog.Test1(h);
            bool w = true;
            if (TBDog_M.Visibility == Visibility.Visible)
            {
                if (res13 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res14 = dog.Test2(i);
            if (TBDog_S.Visibility == Visibility.Visible&w)
            {
                if (res14 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res15 = dog.Test3(j);
            if (TBDog_F.Visibility == Visibility.Visible&w)
            {
                if (res15 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
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

            bool o = true;
            if (PG_DOGM.Value != 0)
            {
                PG_DOGM.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_DOGS.Value != 0)
            {
                PG_DOGS.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }
            if (PG_DOGF.Value != 0)
            {
                PG_DOGF.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o= false;
            }

            res16 = dog.Test1(h);
            bool w = true;
            if (TBDog_M.Visibility == Visibility.Visible)
            {
                if (res16 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res17 = dog.Test2(i);
            if (TBDog_S.Visibility == Visibility.Visible&w)
            {
                if (res17 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res18 = dog.Test3(j);
            if (TBDog_F.Visibility == Visibility.Visible&w)
            {
                if (res18 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

        }
        private void BFeedDOG_Click(object sender, RoutedEventArgs e)
        {
            int f = Convert.ToInt32(TBDog_W.Text);
            int y = Convert.ToInt32(TBDog_S.Text);

            dog.Feed(f, y, f);

            PG_DOGW.Value = dog.Weight;
            PG_DOGS.Value = dog.Satiety;

            TBDog_W.Text = "" + (PG_DOGW.Value);
            TBDog_S.Text = "" + (PG_DOGS.Value);

            bool o = true;
            if (PG_DOGW.Value != 0)
            {
                PG_DOGW.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_DOGS.Value != 0)
            {
                PG_DOGS.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }

            res19 = dog.Test1(h);
            bool w = true;
            if (TBDog_M.Visibility == Visibility.Visible)
            {
                if (res19 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res20 = dog.Test2(i);
            if (TBDog_S.Visibility == Visibility.Visible & w)
            {
                if (res20 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res21 = dog.Test3(j);
            if (TBDog_F.Visibility == Visibility.Visible & w)
            {
                if (res21 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
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

            bool o = true;
            if (PG_DOGM.Value != 0)
            {
                PG_DOGM.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_DOGS.Value != 0)
            {
                PG_DOGS.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_DOGF.Value != 0)
            {
                PG_DOGF.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }

            res22 = dog.Test1(h);
            bool w = true;
            if (TBDog_M.Visibility == Visibility.Visible)
            {
                if (res22 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res23 = dog.Test2(i);
            if (TBDog_S.Visibility == Visibility.Visible&w)
            {
                if (res23 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
            res24 = dog.Test3(j);
            if (TBDog_F.Visibility == Visibility.Visible&w)
            {
                if (res24 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
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

            bool o = true;
            if (PG_CATM.Value != 0)
            {
                PG_CATM.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_CATF.Value != 0)
            {
                PG_CATF.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }

            res25 = cat.Test1(l);
            bool w = true;
            if (TBCat_M.Visibility == Visibility.Visible)
            {
                if (res25 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

            res26 = cat.Test2(m);
            if (TBCat_S.Visibility == Visibility.Visible&w)
            {
                if (res26 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

            res27 = cat.Test3(n);
            if (TBCat_F.Visibility == Visibility.Visible&w)
            {
                if (res27 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
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

            bool o = true;
            if (PG_CATM.Value != 0)
            {
                PG_CATM.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_CATS.Value != 0)
            {
                PG_CATS.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }
            if (PG_CATF.Value != 0)
            {
                PG_CATF.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }

            res28 = cat.Test1(l);
            bool w = true; 
            if (TBCat_M.Visibility == Visibility.Visible)
            {
                if (res28 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

            res29 = cat.Test2(m);
            if (TBCat_S.Visibility == Visibility.Visible&w)
            {
                if (res29 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

            res30 = cat.Test3(n);
            if (TBCat_F.Visibility == Visibility.Visible&w)
            {
                if (res30 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
        }

        private void BFeedCAT1_Click(object sender, RoutedEventArgs e)
        {
            int f = Convert.ToInt32(TBCat_W.Text);
            int y = Convert.ToInt32(TBCat_S.Text);

            cat.Feed(f, y, f);

            PG_CATW.Value = cat.Weight;
            PG_CATS.Value = cat.Satiety;

            TBCat_W.Text = "" + (PG_CATW.Value);
            TBCat_S.Text = "" + (PG_CATS.Value);

            bool o = true;
            if (PG_CATW.Value != 0)
            {
                PG_CATW.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_CATS.Value != 0)
            {
                PG_CATS.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }

            res31 = cat.Test1(l);
            bool w = true;
            if (TBCat_M.Visibility == Visibility.Visible)
            {
                if (res31 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

            res32 = cat.Test2(m);
            if (TBCat_S.Visibility == Visibility.Visible & w)
            {
                if (res32 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

            res33 = cat.Test3(n);
            if (TBCat_F.Visibility == Visibility.Visible & w)
            {
                if (res33 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
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

            bool o = true;
            if (PG_CATM.Value != 0)
            {
                PG_CATM.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o=false;
            }
            if (PG_CATS.Value != 0)
            {
                PG_CATS.Value += 0;
            }
            else if(o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }
            if (PG_CATF.Value != 0)
            {
                PG_CATF.Value += 0;
            }
            else if (o)
            {
                MessageBox.Show("ты убиль его...", "О нет!", MessageBoxButton.OK, MessageBoxImage.Warning);
                o = false;
            }

            res34 = cat.Test1(l);
            bool w = true;
            if (TBCat_M.Visibility == Visibility.Visible)
            {
                if (res34 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

            res35 = cat.Test2(m);
            if (TBCat_S.Visibility == Visibility.Visible&w)
            {
                if (res35 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }

            res36 = cat.Test3(n);
            if (TBCat_F.Visibility == Visibility.Visible&w)
            {
                if (res36 == true) MessageBox.Show("Следующий ход может убить питомца", "Осторожно!", MessageBoxButton.OK, MessageBoxImage.Warning);
                w = false;
            }
        }

        private void BPetRelife1_Click(object sender, RoutedEventArgs e)
        {
            pet = new Pet();

            BSafePET.IsEnabled = true;

            TBPet_W.Text = null;
            TBPet_M.Text = null;
            TBPet_S.Text = null;
            TBPet_F.Text = null;

            TBPet_W.Text = Convert.ToString(a);
            TBPet_M.Text = Convert.ToString(b);
            TBPet_S.Text = Convert.ToString(c);
            TBPet_F.Text = Convert.ToString(d);


            int f = Convert.ToInt32(PG_PETW.Value);
            int x = Convert.ToInt32(PG_PETM.Value);
            int y = Convert.ToInt32(PG_PETS.Value);
            int z = Convert.ToInt32(PG_PETF.Value);

            L1.Content = "";
            L2.Content = "";
            L3.Content = "";
            L4.Content = "";

        }

        private void BDogRelife1_Click(object sender, RoutedEventArgs e)
        {
            dog = new Dog();

            BSafeDOG.IsEnabled = true;

            TBDog_W.Text = null;
            TBDog_M.Text = null;
            TBDog_S.Text = null;
            TBDog_F.Text = null;

            TBDog_W.Text = Convert.ToString(g);
            TBDog_M.Text = Convert.ToString(h);
            TBDog_S.Text = Convert.ToString(i);
            TBDog_F.Text = Convert.ToString(j);

            int f = Convert.ToInt32(PG_DOGW.Value);
            int x = Convert.ToInt32(PG_DOGM.Value);
            int y = Convert.ToInt32(PG_DOGS.Value);
            int z = Convert.ToInt32(PG_DOGF.Value);

            L5.Content = "";
            L6.Content = "";
            L7.Content = "";
            L8.Content = "";
        }

        private void BCatRelife1_Click(object sender, RoutedEventArgs e)
        {
            cat = new Cat();

            BSafeCAT.IsEnabled = true;

            TBCat_W.Text = null;
            TBCat_M.Text = null;
            TBCat_S.Text = null;
            TBCat_F.Text = null;

            TBCat_W.Text = Convert.ToString(k);
            TBCat_M.Text = Convert.ToString(l);
            TBCat_S.Text = Convert.ToString(m);
            TBCat_F.Text = Convert.ToString(n);

            int f = Convert.ToInt32(PG_CATW.Value);
            int x = Convert.ToInt32(PG_CATM.Value);
            int y = Convert.ToInt32(PG_CATS.Value);
            int z = Convert.ToInt32(PG_CATF.Value);

            L9.Content = "";
            L10.Content = "";
            L11.Content = "";
            L12.Content = "";

        }

        private void Okno_Click(object sender, RoutedEventArgs e)
        {
            Laba6 laba6 = new Laba6();
            laba6.Show();
        }
    }
}