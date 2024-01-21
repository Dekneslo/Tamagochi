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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using Pet_Lib7;
using static Pet_Lib7.Pet;
using System.Linq;
using Microsoft.Win32;

namespace Final_ver_8_лаб
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pet> Gachi = new List<Pet>();
        List<Dog> Dachi = new List<Dog>();
        List<Cat> Cachi = new List<Cat>();
        List<Pet> VseVmeste = new List<Pet>();
        public MainWindow()
        {
            InitializeComponent();
        }
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
        int fluff_num = 0;

        public void BSafePET_Click(object sender, RoutedEventArgs e)
        {
            Pet pet = new Pet();
            try
            {
                pet.Name = TBPET_N.Text;
                pet.Weight = Convert.ToInt32(TBPet_W.Text);
                pet.Mood = Convert.ToInt32(TBPet_M.Text);
                pet.Satiety = Convert.ToInt32(TBPet_S.Text);
                pet.Forces = Convert.ToInt32(TBPet_F.Text);
                pet.Fluff = jopa;
                pet.Flufy = int.Parse(LresFluff.Content.ToString());
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
                Gachi.Add(pet);
                
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void BCaressPET_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Pet pet = new Pet();
                int x = Convert.ToInt32(TBPet_M.Text);
                int z = Convert.ToInt32(TBPet_F.Text);
                pet.Smert1 = Convert.ToInt32(TBPet_M.Text);
                pet.Smert3 = Convert.ToInt32(TBPet_F.Text);
                pet.Testing1 = b;
                pet.Testing3 = d;


                pet.Caress(x, z);

                PG_PETM.Value = pet.Mood;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + (PG_PETM.Value);
                TBPet_F.Text = "" + (PG_PETF.Value);
                Gachi.Add(pet);
            }

            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
            {
                int x = Convert.ToInt32(TBPet_M.Text);
                int z = Convert.ToInt32(TBPet_F.Text);

                pet.Caress(x, z);

                PG_PETM.Value = pet.Mood;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + (PG_PETM.Value);
                TBPet_F.Text = "" + (PG_PETF.Value);
            }
        }
        private void BPlayPET1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pet pet = new Pet();
                int x = Convert.ToInt32(TBPet_M.Text);
                int y = Convert.ToInt32(TBPet_S.Text);
                int z = Convert.ToInt32(TBPet_F.Text);
                pet.Smert1 = Convert.ToInt32(TBPet_M.Text);
                pet.Smert2 = Convert.ToInt32(TBPet_S.Text);
                pet.Smert3 = Convert.ToInt32(TBPet_F.Text);
                pet.Testing1 = b;
                pet.Testing2 = c;
                pet.Testing3 = d;


                pet.Play(x, y, z);

                PG_PETM.Value = pet.Mood;
                PG_PETS.Value = pet.Satiety;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + (PG_PETM.Value);
                TBPet_S.Text = "" + (PG_PETS.Value);
                TBPet_F.Text = "" + (PG_PETF.Value);
                Gachi.Add(pet);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
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
            }
        }

        private void BFeedPET1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pet pet = new Pet();
                int f = Convert.ToInt32(TBPet_W.Text);
                int y = Convert.ToInt32(TBPet_S.Text);
                pet.Smert2 = Convert.ToInt32(TBPet_S.Text);
                pet.Testing2 = c;
                pet.Feed(f, y, f);

                PG_PETW.Value = pet.Weight;
                PG_PETS.Value = pet.Satiety;

                TBPet_W.Text = "" + (PG_PETW.Value);
                TBPet_S.Text = "" + (PG_PETS.Value);
                Gachi.Add(pet);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
            {
                int f = Convert.ToInt32(TBPet_W.Text);
                int y = Convert.ToInt32(TBPet_S.Text);
                pet.Feed(f, y, f);

                PG_PETW.Value = pet.Weight;
                PG_PETS.Value = pet.Satiety;

                TBPet_W.Text = "" + (PG_PETW.Value);
                TBPet_S.Text = "" + (PG_PETS.Value);
            }
        }

        private void BTrainPET1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pet pet = new Pet();
                int x = Convert.ToInt32(TBPet_M.Text);
                int y = Convert.ToInt32(TBPet_S.Text);
                int z = Convert.ToInt32(TBPet_F.Text);
                pet.Smert1 = Convert.ToInt32(TBPet_M.Text);
                pet.Smert2 = Convert.ToInt32(TBPet_S.Text);
                pet.Smert3 = Convert.ToInt32(TBPet_F.Text);
                pet.Testing1 = b;
                pet.Testing2 = c;
                pet.Testing3 = d;

                pet.Train(x, y, z);

                PG_PETM.Value = pet.Mood;
                PG_PETS.Value = pet.Satiety;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + (PG_PETM.Value);
                TBPet_S.Text = "" + (PG_PETS.Value);
                TBPet_F.Text = "" + (PG_PETF.Value);
                Gachi.Add(pet);

            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
            {
                int x = Convert.ToInt32(TBPet_M.Text);
                int y = Convert.ToInt32(TBPet_S.Text);
                pet.Train(x, y, z);

                PG_PETM.Value = pet.Mood;
                PG_PETS.Value = pet.Satiety;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + (PG_PETM.Value);
                TBPet_S.Text = "" + (PG_PETS.Value);
                TBPet_F.Text = "" + (PG_PETF.Value);
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

        public void BSafeDOG_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            try
            {
                dog.Name = TBDOG_N.Text;
                dog.Weight = Convert.ToInt32(TBDog_W.Text);
                dog.Mood = Convert.ToInt32(TBDog_M.Text);
                dog.Satiety = Convert.ToInt32(TBDog_S.Text);
                dog.Forces = Convert.ToInt32(TBDog_F.Text);
                dog.Fluff = jopa;
                dog.Flufy = int.Parse(LresFluff.Content.ToString());

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
                //Gachi.Add(dog);
                Dachi.Add(dog);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void BCaressDOG1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dog dog = new Dog();
                int x = Convert.ToInt32(TBDog_M.Text);
                int z = Convert.ToInt32(TBDog_F.Text);
                dog.Testing1 = h;
                dog.Testing3 = j;
                dog.Smert1 = Convert.ToInt32(TBDog_M.Text);
                dog.Smert3 = Convert.ToInt32(TBDog_F.Text);
                dog.Caress(x, z);

                PG_DOGM.Value = dog.Mood;
                PG_DOGF.Value = dog.Forces;

                TBDog_M.Text = "" + (PG_DOGM.Value);
                TBDog_F.Text = "" + (PG_DOGF.Value);
                //Gachi.Add(dog);\
                Dachi.Add(dog);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
            {
                int x = Convert.ToInt32(TBDog_M.Text);
                int z = Convert.ToInt32(TBDog_F.Text);

                dog.Caress(x, z);

                PG_DOGM.Value = dog.Mood;
                PG_DOGF.Value = dog.Forces;

                TBDog_M.Text = "" + (PG_DOGM.Value);
                TBDog_F.Text = "" + (PG_DOGF.Value);
            }
        }

        private void BPlayDOG2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dog dog = new Dog();
                int x = Convert.ToInt32(TBDog_M.Text);
                int y = Convert.ToInt32(TBDog_S.Text);
                int z = Convert.ToInt32(TBDog_F.Text);
                dog.Testing1 = h;
                dog.Testing2 = i;
                dog.Testing3 = j;
                dog.Smert1 = Convert.ToInt32(TBDog_M.Text);
                dog.Smert2 = Convert.ToInt32(TBDog_S.Text);
                dog.Smert3 = Convert.ToInt32(TBDog_F.Text);
                dog.Play(x, y, z);

                PG_DOGM.Value = dog.Mood;
                PG_DOGS.Value = dog.Satiety;
                PG_DOGF.Value = dog.Forces;

                TBDog_M.Text = "" + (PG_DOGM.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
                TBDog_F.Text = "" + (PG_DOGF.Value);
                //Gachi.Add(dog);
                Dachi.Add(dog);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
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
            }
        }

        private void BFeedDOG_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dog dog = new Dog();
                int f = Convert.ToInt32(TBDog_W.Text);
                int y = Convert.ToInt32(TBDog_S.Text);
                dog.Testing2 = i;
                dog.Smert2 = Convert.ToInt32(TBDog_S.Text);
                //dog.Smert3 = Convert.ToInt32(TBDog_F.Text);
                dog.Feed(f, y, f);

                PG_DOGW.Value = dog.Weight;
                PG_DOGS.Value = dog.Satiety;

                TBDog_W.Text = "" + (PG_DOGW.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
                //Gachi.Add(dog);
                Dachi.Add(dog);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
            {
                int f = Convert.ToInt32(TBDog_W.Text);
                int y = Convert.ToInt32(TBDog_S.Text);
                dog.Feed(f, y, f);

                PG_DOGW.Value = dog.Weight;
                PG_DOGS.Value = dog.Satiety;

                TBDog_W.Text = "" + (PG_DOGW.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
            }
        }

        private void BTrainDOG1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dog dog = new Dog();
                int x = Convert.ToInt32(TBDog_M.Text);
                int y = Convert.ToInt32(TBDog_S.Text);
                int z = Convert.ToInt32(TBDog_F.Text);
                dog.Testing1 = h;
                dog.Testing2 = i;
                dog.Testing3 = j;
                dog.Smert1 = Convert.ToInt32(TBDog_M.Text);
                dog.Smert2 = Convert.ToInt32(TBDog_S.Text);
                dog.Smert3 = Convert.ToInt32(TBDog_F.Text);
                dog.Train(x, y, z);

                PG_DOGM.Value = dog.Mood;
                PG_DOGS.Value = dog.Satiety;
                PG_DOGF.Value = dog.Forces;

                TBDog_M.Text = "" + (PG_DOGM.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
                TBDog_F.Text = "" + (PG_DOGF.Value);
                //Gachi.Add(dog);
                Dachi.Add(dog);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
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
            }
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

        public void BSafeCAT_Click(object sender, RoutedEventArgs e)
        {
            Cat cat = new Cat();
            try
            {
                cat.Name = TBCAT_N.Text;
                cat.Weight = Convert.ToInt32(TBCat_W.Text);
                cat.Mood = Convert.ToInt32(TBCat_M.Text);
                cat.Satiety = Convert.ToInt32(TBCat_S.Text);
                cat.Forces = Convert.ToInt32(TBCat_F.Text);
                cat.Fluff = jopa;
                cat.Flufy = int.Parse(LresFluff.Content.ToString());

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
                Cachi.Add(cat);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void BCaressCAT1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cat cat = new Cat();
                int x = Convert.ToInt32(TBCat_M.Text);
                int z = Convert.ToInt32(TBCat_F.Text);
                cat.Testing1 = l;
                cat.Testing3 = n;
                cat.Smert1 = Convert.ToInt32(TBCat_M.Text);
                cat.Smert3 = Convert.ToInt32(TBCat_F.Text);
                cat.Caress(x, z);

                PG_CATM.Value = cat.Mood;
                PG_CATF.Value = cat.Forces;

                TBCat_M.Text = "" + (PG_CATM.Value);
                TBCat_F.Text = "" + (PG_CATF.Value);
                Cachi.Add(cat);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
            {
                int x = Convert.ToInt32(TBCat_M.Text);
                int z = Convert.ToInt32(TBCat_F.Text);

                cat.Caress(x, z);

                PG_CATM.Value = cat.Mood;
                PG_CATF.Value = cat.Forces;

                TBCat_M.Text = "" + (PG_CATM.Value);
                TBCat_F.Text = "" + (PG_CATF.Value);
            }
        }

        private void BPlayCAT1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cat cat = new Cat();
                int x = Convert.ToInt32(TBCat_M.Text);
                int y = Convert.ToInt32(TBCat_S.Text);
                int z = Convert.ToInt32(TBCat_F.Text);
                cat.Testing1 = l;
                cat.Testing2 = m;
                cat.Testing3 = n;
                cat.Smert1 = Convert.ToInt32(TBCat_M.Text);
                cat.Smert2 = Convert.ToInt32(TBCat_S.Text);
                cat.Smert3 = Convert.ToInt32(TBCat_F.Text);
                cat.Play(x, y, z);

                PG_CATM.Value = cat.Mood;
                PG_CATS.Value = cat.Satiety;
                PG_CATF.Value = cat.Forces;

                TBCat_M.Text = "" + (PG_CATM.Value);
                TBCat_S.Text = "" + (PG_CATS.Value);
                TBCat_F.Text = "" + (PG_CATF.Value);
                Cachi.Add(cat);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
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
            }
        }

        private void BFeedCAT1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cat cat = new Cat();
                int f = Convert.ToInt32(TBCat_W.Text);
                int y = Convert.ToInt32(TBCat_S.Text);
                cat.Testing2 = m;
                cat.Smert2 = Convert.ToInt32(TBCat_S.Text);
                cat.Feed(f, y, f);

                PG_CATW.Value = cat.Weight;
                PG_CATS.Value = cat.Satiety;

                TBCat_W.Text = "" + (PG_CATW.Value);
                TBCat_S.Text = "" + (PG_CATS.Value);
                Cachi.Add(cat);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
            {
                int f = Convert.ToInt32(TBCat_W.Text);
                int y = Convert.ToInt32(TBCat_S.Text);
                cat.Feed(f, y, f);

                PG_CATW.Value = cat.Weight;
                PG_CATS.Value = cat.Satiety;

                TBCat_W.Text = "" + (PG_CATW.Value);
                TBCat_S.Text = "" + (PG_CATS.Value);
            }
        }

        private void BTrainCAT1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cat cat = new Cat();
                int x = Convert.ToInt32(TBCat_M.Text);
                int y = Convert.ToInt32(TBCat_S.Text);
                int z = Convert.ToInt32(TBCat_F.Text);
                cat.Testing1 = l;
                cat.Testing2 = m;
                cat.Testing3 = n;
                cat.Smert1 = Convert.ToInt32(TBCat_M.Text);
                cat.Smert2 = Convert.ToInt32(TBCat_S.Text);
                cat.Smert3 = Convert.ToInt32(TBCat_F.Text);
                cat.Train(x, y, z);

                PG_CATM.Value = cat.Mood;
                PG_CATS.Value = cat.Satiety;
                PG_CATF.Value = cat.Forces;

                TBCat_M.Text = "" + (PG_CATM.Value);
                TBCat_S.Text = "" + (PG_CATS.Value);
                TBCat_F.Text = "" + (PG_CATF.Value);
                Cachi.Add(cat);
            }
            catch (PetException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
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
            }
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


        private void ComTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComTheme.SelectedIndex)
            {
                case 0:
                    {
                        Canvas.Background = Brushes.Yellow;
                        Canvas1.Background = Brushes.Yellow;
                        Canvas2.Background = Brushes.Yellow;
                        Canvas3.Background = Brushes.Yellow;

                        TRES.Foreground= Brushes.Black;

                        PG_PETW.Foreground = Brushes.Gray;
                        PG_PETM.Foreground = Brushes.Gray;
                        PG_PETS.Foreground = Brushes.Gray;
                        PG_PETF.Foreground = Brushes.Gray;
                        PG_PETFL.Foreground = Brushes.Gray;

                        PG_DOGW.Foreground = Brushes.Gray;
                        PG_DOGM.Foreground = Brushes.Gray;
                        PG_DOGS.Foreground = Brushes.Gray;
                        PG_DOGF.Foreground = Brushes.Gray;
                        PG_DOGFL.Foreground = Brushes.Gray;

                        PG_CATW.Foreground = Brushes.Gray;
                        PG_CATM.Foreground = Brushes.Gray;
                        PG_CATS.Foreground = Brushes.Gray;
                        PG_CATF.Foreground = Brushes.Gray;
                        PG_CATFL.Foreground = Brushes.Gray;
                        break;
                    }

                case 1:
                    {
                        Canvas.Background = Brushes.Salmon;
                        Canvas1.Background = Brushes.Salmon;
                        Canvas2.Background = Brushes.Salmon;
                        Canvas3.Background = Brushes.Salmon;

                        TRES.Foreground = Brushes.Black;

                        PG_PETW.Foreground = Brushes.Orange;
                        PG_PETM.Foreground = Brushes.Orange;
                        PG_PETS.Foreground = Brushes.Orange;
                        PG_PETF.Foreground = Brushes.Orange;
                        PG_PETFL.Foreground = Brushes.Orange;

                        PG_DOGW.Foreground = Brushes.Orange;
                        PG_DOGM.Foreground = Brushes.Orange;
                        PG_DOGS.Foreground = Brushes.Orange;
                        PG_DOGF.Foreground = Brushes.Orange;
                        PG_DOGFL.Foreground = Brushes.Orange;

                        PG_CATW.Foreground = Brushes.Orange;
                        PG_CATM.Foreground = Brushes.Orange;
                        PG_CATS.Foreground = Brushes.Orange;
                        PG_CATF.Foreground = Brushes.Orange;
                        PG_CATFL.Foreground = Brushes.Orange;
                        break;
                    }

                case 2:
                    {
                        Canvas.Background = Brushes.Azure;
                        Canvas1.Background = Brushes.Azure;
                        Canvas2.Background = Brushes.Azure;
                        Canvas3.Background = Brushes.Azure;

                        TRES.Foreground = Brushes.Black;

                        PG_PETW.Foreground = Brushes.Cyan;
                        PG_PETM.Foreground = Brushes.Cyan;
                        PG_PETS.Foreground = Brushes.Cyan;
                        PG_PETF.Foreground = Brushes.Cyan;
                        PG_PETFL.Foreground = Brushes.Cyan;

                        PG_DOGW.Foreground = Brushes.Cyan;
                        PG_DOGM.Foreground = Brushes.Cyan;
                        PG_DOGS.Foreground = Brushes.Cyan;
                        PG_DOGF.Foreground = Brushes.Cyan;
                        PG_DOGFL.Foreground = Brushes.Cyan;

                        PG_CATW.Foreground = Brushes.Cyan;
                        PG_CATM.Foreground = Brushes.Cyan;
                        PG_CATS.Foreground = Brushes.Cyan;
                        PG_CATF.Foreground = Brushes.Cyan;
                        PG_CATFL.Foreground = Brushes.Cyan;
                        break;
                    }

                case 3:
                    {
                        Canvas.Background = Brushes.Teal;
                        Canvas1.Background = Brushes.Teal;
                        Canvas2.Background = Brushes.Teal;
                        Canvas3.Background = Brushes.Teal;

                        PG_PETW.Foreground = Brushes.LawnGreen;
                        PG_PETM.Foreground = Brushes.LawnGreen;
                        PG_PETS.Foreground = Brushes.LawnGreen;
                        PG_PETF.Foreground = Brushes.LawnGreen;
                        PG_PETFL.Foreground = Brushes.LawnGreen;

                        PG_DOGW.Foreground = Brushes.LawnGreen;
                        PG_DOGM.Foreground = Brushes.LawnGreen;
                        PG_DOGS.Foreground = Brushes.LawnGreen;
                        PG_DOGF.Foreground = Brushes.LawnGreen;
                        PG_DOGFL.Foreground = Brushes.LawnGreen;

                        PG_CATW.Foreground = Brushes.LawnGreen;
                        PG_CATM.Foreground = Brushes.LawnGreen;
                        PG_CATS.Foreground = Brushes.LawnGreen;
                        PG_CATF.Foreground = Brushes.LawnGreen;
                        PG_CATFL.Foreground = Brushes.LawnGreen;
                        break;
                    }
            }
        }
        string jopa;

        private void ComFluf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (ComFluf.SelectedIndex)
            {
                case 0:
                    {
                        if (Canvas1.Visibility == Visibility.Visible)
                        {
                            pet.Fluff = "Лысый";
                            pet.Sherst1();
                            LresFluff.Content = pet.Flufy;
                            PG_PETFL.Value=pet.Flufy;
                            //pp=pet.Flufy; 
                            //pp= Convert.ToInt32(TBTB.Text);
                            jopa = "Лысый";
                            //TRES.Content = "\nИмя Питомца: " + TBPET_N.Text + "\nСтепень пушистости: " + "Лысый" + LresFluff.Content + "\nВес: " + TBPet_W.Text + "\nНастроение: " + TBPet_M.Text + "\nСытость: " + TBPet_S.Text + "\nСилы: " + TBPet_F.Text;
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Fluff = "Лысый";
                            dog.Sherst1();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value = dog.Flufy;
                            //kk = pet.Flufy;
                            //kk = Convert.ToInt32(TBTB.Text);
                            //LresFluff.Content = Convert.ToInt32(TBTB.Text);
                            jopa = "Лысый";
                            //TRES.Content = "\nИмя Собаки: " + TBDOG_N.Text + "\nСтепень пушистости: " + "Лысый" + LresFluff + "\nВес: " + TBDog_W.Text + "\nНастроение: " + TBDog_M.Text + "\nСытость: " + TBDog_S.Text + "\nСилы: " + TBDog_F.Text;
                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Fluff = "Лысый";
                            cat.Sherst1();
                            LresFluff.Content = cat.Flufy;
                            PG_CATFL.Value = cat.Flufy;
                            //yy = pet.Flufy;
                            //yy = Convert.ToInt32(TBTB.Text);
                            //LresFluff.Content = Convert.ToInt32(TBTB.Text);
                            jopa = "Лысый";
                            //    TRES.Content = "\nИмя Кошки: " + TBCAT_N.Text + "\nСтепень пушистости: " + "Лысый" + LresFluff + "\nВес: " + TBCat_W.Text + "\nНастроение: " + TBCat_M.Text + "\nСытость: " + TBCat_S.Text + "\nСилы: " + TBCat_F.Text;
                        }
                        break;
                    }

                case 1:
                    {
                        if (Canvas1.Visibility == Visibility.Visible)
                        {
                            pet.Fluff = "Короткошерстный";
                            pet.Sherst2();
                            LresFluff.Content = pet.Flufy;
                            PG_PETFL.Value = pet.Flufy;
                            //hh = pet.Flufy;
                            //hh = Convert.ToInt32(TBTB.Text);
                            //LresFluff.Content = Convert.ToInt32(TBTB.Text);
                            jopa = "Короткошерстный";
                            //TRES.Content = "\nИмя Питомца: " + TBPET_N.Text + "\nСтепень пушистости: " + "Короткошерстный" + LresFluff.Content + "\nВес: " + TBPet_W.Text + "\nНастроение: " + TBPet_M.Text + "\nСытость: " + TBPet_S.Text + "\nСилы: " + TBPet_F.Text;
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Sherst2();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value = dog.Flufy;
                            //rr = pet.Flufy;
                            //rr = TBTB.Text;
                            //LresFluff.Content = Convert.ToInt32(TBTB.Text);
                            dog.Fluff = "Короткошерстный";
                            jopa = "Короткошерстный";
                            //TRES.Content = "\nИмя Собаки: " + TBDOG_N.Text + "\nСтепень пушистости: " + "Короткошерстный" + LresFluff.Content + "\nВес: " + TBDog_W.Text + "\nНастроение: " + TBDog_M.Text + "\nСытость: " + TBDog_S.Text + "\nСилы: " + TBDog_F.Text;
                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Sherst2();
                            LresFluff.Content = cat.Flufy;
                            PG_CATFL.Value = cat.Flufy;
                            //rr = pet.Flufy;
                            //rr = TBTB.Text;
                            //LresFluff.Content = Convert.ToInt32(TBTB.Text);
                            cat.Fluff = "Короткошерстный";
                            jopa = "Короткошерстный";
                            //TRES.Content = "\nИмя Кошки: " + TBCAT_N.Text + "\nСтепень пушистости: " + "Короткошерстный" + LresFluff.Content + "\nВес: " + TBCat_W.Text + "\nНастроение: " + TBCat_M.Text + "\nСытость: " + TBCat_S.Text + "\nСилы: " + TBCat_F.Text;
                        }

                        break;
                    }
                case 2:
                    {
                        if (Canvas1.Visibility == Visibility.Visible)
                        {
                            pet.Sherst3();
                            LresFluff.Content = pet.Flufy;
                            PG_PETFL.Value = pet.Flufy;
                            pet.Fluff = "Среднешерстный";
                            jopa = "Среднешерстный";
                            //TRES.Content = "\nИмя Питомца: " + TBPET_N.Text + "\nСтепень пушистости: " + "Среднешерстный" + LresFluff.Content + "\nВес: " + TBPet_W.Text + "\nНастроение: " + TBPet_M.Text + "\nСытость: " + TBPet_S.Text + "\nСилы: " + TBPet_F.Text;
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Sherst3();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value = dog.Flufy;
                            dog.Fluff = "Среднешерстный";
                            jopa = "Среднешерстный";
                            //TRES.Content = "\nИмя Собаки: " + TBDOG_N.Text + "\nСтепень пушистости: " + "Среднешерстный" + LresFluff.Content + "\nВес: " + TBDog_W.Text + "\nНастроение: " + TBDog_M.Text + "\nСытость: " + TBDog_S.Text + "\nСилы: " + TBDog_F.Text;
                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Sherst3();
                            LresFluff.Content = cat.Flufy;
                            PG_CATFL.Value = cat.Flufy;
                            cat.Fluff = "Среднешерстный";
                            jopa = "Среднешерстный";
                            //TRES.Content = "\nИмя Кошки: " + TBCAT_N.Text + "\nСтепень пушистости: " + "Среднешерстный" + LresFluff.Content + "\nВес: " + TBCat_W.Text + "\nНастроение: " + TBCat_M.Text + "\nСытость: " + TBCat_S.Text + "\nСилы: " + TBCat_F.Text;
                        }

                        break;
                    }
                case 3:
                    {
                        if (Canvas1.Visibility == Visibility.Visible)
                        {
                            pet.Sherst4();
                            LresFluff.Content = pet.Flufy;
                            PG_PETFL.Value = pet.Flufy;
                            pet.Fluff = "Длинношерстный";
                            jopa = "Длинношерстный";
                            //TRES.Content = "\nИмя Питомца: " + TBPET_N.Text + "\nСтепень пушистости: " + "Длинношерстный" + LresFluff.Content + "\nВес: " + TBPet_W.Text + "\nНастроение: " + TBPet_M.Text + "\nСытость: " + TBPet_S.Text + "\nСилы: " + TBPet_F.Text;
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Sherst4();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value = dog.Flufy;
                            dog.Fluff = "Длинношерстный";
                            jopa = "Длинношерстный";
                            //TRES.Content = "\nИмя Собаки: " + TBDOG_N.Text + "\nСтепень пушистости: " + "Длинношерстный" + LresFluff.Content + "\nВес: " + TBDog_W.Text + "\nНастроение: " + TBDog_M.Text + "\nСытость: " + TBDog_S.Text + "\nСилы: " + TBDog_F.Text;
                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Sherst4();
                            LresFluff.Content = cat.Flufy;
                            PG_CATFL.Value = cat.Flufy;
                            cat.Fluff = "Длинношерстный";
                            jopa = "Длинношерстный";
                            //TRES.Content = "\nИмя Кошки: " + TBCAT_N.Text + "\nСтепень пушистости: " + "Длинношерстный" + LresFluff.Content + "\nВес: " + TBCat_W.Text + "\nНастроение: " + TBCat_M.Text + "\nСытость: " + TBCat_S.Text + "\nСилы: " + TBCat_F.Text;
                        }

                        break;
                    }

                case 4:
                    {
                        if (Canvas1.Visibility == Visibility.Visible)
                        {
                            pet.Sherst5();
                            LresFluff.Content = pet.Flufy;
                            PG_PETFL.Value = pet.Flufy;
                            pet.Fluff = "Кудрявый";
                            jopa = "Кудрявый";
                            //TRES.Content = "\nИмя Питомца: " + TBPET_N.Text + "\nСтепень пушистости: " + "Кудрявый" + LresFluff.Content + "\nВес: " + TBPet_W.Text + "\nНастроение: " + TBPet_M.Text + "\nСытость: " + TBPet_S.Text + "\nСилы: " + TBPet_F.Text;
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Sherst5();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value=dog.Flufy;
                            dog.Fluff = "Кудрявый";
                            jopa = "Кудрявый";
                            //TRES.Content = "\nИмя Собаки: " + TBDOG_N.Text + "\nСтепень пушистости: " + "Кудрявый" + LresFluff.Content + "\nВес: " + TBDog_W.Text + "\nНастроение: " + TBDog_M.Text + "\nСытость: " + TBDog_S.Text + "\nСилы: " + TBDog_F.Text;

                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Sherst5();
                            LresFluff.Content = pet.Flufy;
                            PG_CATFL.Value=cat.Flufy;
                            cat.Fluff = "Кудрявый";
                            jopa = "Кудрявый";
                            //TRES.Content = "\nИмя Кошки: " + TBCAT_N.Text + "\nСтепень пушистости: " + "Кудрявый" + LresFluff.Content + "\nВес: " + TBCat_W.Text + "\nНастроение: " + TBCat_M.Text + "\nСытость: " + TBCat_S.Text + "\nСилы: " + TBCat_F.Text;

                        }
                        break;
                    }
            }
        }

        private void ComboBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboBox1.SelectedIndex)
            {
                case 0:
                    {
                        Canvas1.Visibility = Visibility.Visible;
                        Canvas2.Visibility = Visibility.Hidden;
                        Canvas3.Visibility = Visibility.Hidden;
                        break;
                    }

                case 1:
                    {
                        Canvas2.Visibility = Visibility.Visible;
                        Canvas1.Visibility = Visibility.Hidden;
                        Canvas3.Visibility = Visibility.Hidden;
                        break;
                    }

                case 2:
                    {
                        Canvas3.Visibility = Visibility.Visible;
                        Canvas2.Visibility = Visibility.Hidden;
                        Canvas1.Visibility = Visibility.Hidden;
                        break;
                    }
            }
        }
        private void Trash1_Click(object sender, RoutedEventArgs e)
        {
            TBPET_N.Text = "";
            TBPet_W.Text = "";
            TBPet_M.Text = "";
            TBPet_S.Text = "";
            TBPet_F.Text = "";
            PG_PETWMax.Text = "";
            PG_PETMax.Text = "";
            PG_PETW.Value = 0;
            PG_PETM.Value = 0;
            PG_PETS.Value = 0;
            PG_PETF.Value = 0;
            PG_PETFL.Value = 0;
        }
        private void Trash2_Click(object sender, RoutedEventArgs e)
        {
            TBDOG_N.Text = "";
            TBDog_W.Text = "";
            TBDog_M.Text = "";
            TBDog_S.Text = "";
            TBDog_F.Text = "";
            PG_DOGWMax.Text = "";
            PG_DOGMax.Text = "";
            PG_DOGW.Value = 0;
            PG_DOGM.Value = 0;
            PG_DOGS.Value = 0;
            PG_DOGF.Value = 0;
            PG_DOGFL.Value = 0;
        }
        private void Trash3_Click(object sender, RoutedEventArgs e)
        {
            TBCAT_N.Text = "";
            TBCat_W.Text = "";
            TBCat_M.Text = "";
            TBCat_S.Text = "";
            TBCat_F.Text = "";
            PG_CATWMax.Text = "";
            PG_CATMax.Text = "";
            PG_CATW.Value = 0;
            PG_CATM.Value = 0;
            PG_CATS.Value = 0;
            PG_CATF.Value = 0;
            PG_CATFL.Value = 0;
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {

            //List<Pet> Ves = new List<Pet>();
            //List<Pet> Gachi = new List<Pet>();
            //List<Dog> Dachi = new List<Dog>();
            //List<Cat> Cachi = new List<Cat>();
            //try
            //{
            Pet pet = new Pet();
            pet.Weight = Convert.ToInt32(TBPet_W.Text);
            pet.Mood = Convert.ToInt32(TBPet_M.Text);
            pet.Satiety = Convert.ToInt32(TBPet_S.Text);
            pet.Forces = Convert.ToInt32(TBPet_F.Text);
            //TBTB.Text=PG_PETFL.Value + "";
            pet.Flufy = Convert.ToInt32(LresFluff.Content);
            Gachi.Add(pet);

            Dog dog = new Dog();
            dog.Weight = Convert.ToInt32(TBDog_W.Text);
            dog.Mood = Convert.ToInt32(TBDog_M.Text);
            dog.Satiety = Convert.ToInt32(TBDog_S.Text);
            dog.Forces = Convert.ToInt32(TBDog_F.Text);
            dog.Flufy = Convert.ToInt32(LresFluff.Content);
            Dachi.Add(dog);

            Cat cat = new Cat();
            cat.Weight = Convert.ToInt32(TBCat_W.Text);
            cat.Mood = Convert.ToInt32(TBCat_M.Text);
            cat.Satiety = Convert.ToInt32(TBCat_S.Text);
            cat.Forces = Convert.ToInt32(TBCat_F.Text);
            cat.Flufy = Convert.ToInt32(LresFluff.Content);
            Cachi.Add(cat);

            //PG_PETFL.Value = pet.Flufy;
            //PG_DOGFL.Value = dog.Flufy;
            //PG_CATFL.Value = cat.Flufy;
            //LRESCount.Content = "";

            //СРЕДНЕЕ ЗНАЧЕНИЕ
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;
            int sum7 = 0;
            int sum8 = 0;
            int sum9 = 0;
            int sum10 = 0;
            int sum11 = 0;
            int sum12 = 0;
            int sum13 = 0;
            int sum14 = 0;
            int sum15 = 0;

            foreach (Pet i in Gachi)
            {
                sum1 += i.Weight;
            }
            //double avge1 = sum1 / (double)Gachi.Count;

            foreach (Pet i in Gachi)
            {
                sum2 += i.Mood;
            }
            //double avge2 = sum2 / (double)Gachi.Count;

            foreach (Pet i in Gachi)
            {
                sum3 += i.Satiety;
            }
            //double avge3 = sum3 / (double)Gachi.Count;

            foreach (Pet i in Gachi)
            {
                sum4 += i.Forces;
            }
            //double avge4 = sum4 / (double)Gachi.Count;

            foreach (Pet i in Gachi)
            {
                sum5 += i.Flufy;
            }
            //double avge5 = sum5 / (double)Gachi.Count;



            foreach (Dog d in Dachi)
            {
                sum6 += d.Weight;
            }
            /*double avge6 = sum6 / (double)Dachi.Count;*/

            foreach (Dog d in Dachi)
            {
                sum7 += d.Mood;
            }
            //double avge7 = sum7 / (double)Dachi.Count;

            foreach (Dog d in Dachi)
            {
                sum8 += d.Satiety;
            }
            //double avge8 = sum8 / (double)Dachi.Count;

            foreach (Dog d in Dachi)
            {
                sum9 += d.Forces;
            }
            //double avge9 = sum9 / (double)Dachi.Count;

            foreach (Dog d in Dachi)
            {
                sum10 += d.Flufy;
            }
            /*double avge10 = sum10 / (double)Dachi.Count;*/



            foreach (Cat c in Cachi)
            {
                sum11 += c.Weight;
            }
            //double avge11 = sum11 / (double)Cachi.Count;
            foreach (Cat c in Cachi)
            {
                sum12 += c.Mood;
            }
            //double avge12 = sum12 / (double)Cachi.Count;
            foreach (Cat c in Cachi)
            {
                sum13 += c.Satiety;
            }
            //double avge13 = sum13 / (double)Cachi.Count;
            foreach (Cat c in Cachi)
            {
                sum14 += c.Forces;
            }
            //double avge14 = sum14 / (double)Cachi.Count;
            foreach (Cat c in Cachi)
            {
                sum15 += c.Flufy;
            }
            //double avge15 = sum15 / (double)Cachi.Count;

            double sumW = sum1 + sum6 + sum11;
            double sumM = sum2 + sum7 + sum12;
            double sumS = sum3 + sum8 + sum13;
            double sumF = sum4 + sum9 + sum14;
            double sumFL = sum5 + sum10 + sum15;

            double avgW = (double)sumW / (Gachi.Count+ Dachi.Count+ Cachi.Count);
            double avgM = (double)sumM / (Gachi.Count + Dachi.Count + Cachi.Count);
            double avgS = (double)sumS / (Gachi.Count + Dachi.Count + Cachi.Count);
            double avgF = (double)sumF / (Gachi.Count + Dachi.Count + Cachi.Count);
            double avgFL = (double)sumFL / (Gachi.Count + Dachi.Count + Cachi.Count);


            //double avgW = avge1 + avge6 + avge11;
            //double avgM = avge2 + avge7 + avge12;
            //double avgS = avge3 + avge8 + avge13;
            //double avgF = avge4 + avge9 + avge14;
            //double avgFL = avge5 + avge10 + avge15;


            //МЕДИАНА 

            List<int> VseVmeste = new List<int>();
            List<int> VseVmeste2 = new List<int>();
            List<int> VseVmeste3 = new List<int>();
            List<int> VseVmeste4 = new List<int>();
            List<int> VseVmeste5 = new List<int>();

            VseVmeste.Add(pet.Weight);
            VseVmeste.Add(dog.Weight);
            VseVmeste.Add(cat.Weight);

            VseVmeste2.Add(pet.Mood);
            VseVmeste2.Add(dog.Mood);
            VseVmeste2.Add(cat.Mood);


            VseVmeste3.Add(pet.Satiety);
            VseVmeste3.Add(dog.Satiety);
            VseVmeste3.Add(cat.Satiety);

            VseVmeste4.Add(pet.Forces);
            VseVmeste4.Add(dog.Forces);
            VseVmeste4.Add(cat.Forces);

            VseVmeste5.Add(pet.Flufy);
            VseVmeste5.Add(dog.Flufy);
            VseVmeste5.Add(cat.Flufy);

            double medianW;
            double medianM;
            double medianS;
            double medianF;
            double medianFL;

            VseVmeste.Sort();
            VseVmeste2.Sort();
            VseVmeste3.Sort();
            VseVmeste4.Sort();
            VseVmeste5.Sort();


            if (VseVmeste.Count % 2 == 0)
            { 
                medianW = (VseVmeste[VseVmeste.Count / 2 - 1] + VseVmeste[VseVmeste.Count / 2]) / 2;
                medianM = (VseVmeste2[VseVmeste2.Count / 2 - 1] + VseVmeste2[VseVmeste2.Count / 2]) / 2;
                medianS = (VseVmeste3[VseVmeste3.Count / 2 - 1] + VseVmeste3[VseVmeste3.Count / 2]) / 2;
                medianF = (VseVmeste4[VseVmeste4.Count / 2 - 1] + VseVmeste4[VseVmeste4.Count / 2]) / 2;
                medianFL = (VseVmeste5[VseVmeste5.Count / 2 - 1] + VseVmeste5[VseVmeste5.Count / 2]) / 2;
            }
            else
            { 
                medianW = VseVmeste[VseVmeste.Count / 2];
                medianM = VseVmeste2[VseVmeste2.Count / 2];
                medianS = VseVmeste3[VseVmeste3.Count / 2];
                medianF = VseVmeste4[VseVmeste4.Count / 2];
                medianFL = VseVmeste5[VseVmeste5.Count / 2];
            }
                

                LRESCount.Content += "Ср.зн. Веса" + " "+ avgW + " " + "Медиана" + " " + medianW + "\n"+
                "Ср.зн. Настроения" + " " + avgM + " " + "Медиана" + " " + medianM + "\n"+
                "Ср.зн. Сытости" + " " + avgS + " " + "Медиана" + " " + medianS + "\n"+
                "Ср.зн. Силы" + " " + avgF + " " + "Медиана" + " " + medianF + "\n"+
                "Ср.зн. Пушистости" + " " + avgFL + " " + "Медиана" + " " + medianFL + "\n";


            
        }
        private void BRes_Click(object sender, RoutedEventArgs e)
        {

            TRES.Content = "";
            foreach (Pet k in Gachi)
                TRES.Content += k.Info() + "\n";
        }
        private void BResdog_Click(object sender, RoutedEventArgs e)
        {
            //TRES.Content = "";
            foreach (Dog f in Dachi)
                TRES.Content += f.Info() + "\n";
        }

        private void BRescat_Click(object sender, RoutedEventArgs e)
        {
            //TRES.Content = "";
            foreach (Cat s in Cachi)
                TRES.Content += s.Info() + "\n";
        }

        //private void B_Ow_Pet_Click(object sender, RoutedEventArgs e)
        //{
        //    string registr;
        //    string text = TB_Phrase_P.Text;
        //    //меняет слова местами, первый с последним
        //    string[] mas = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        //    if (mas.Length > 1)
        //    {
        //        text = "";
        //        for (int i = 1; i < mas.Length - 1; i++)
        //            text += mas[i] + " ";
        //        text = mas[mas.Length - 1] + " " + text + mas[0];
        //    }
        //    //меняет регистр слов, первое слово с заглавной буквы, остальное в нижнем регистре
        //    var str = text.ToLower();
        //    if (str.Length > 1)
        //    {
        //        registr = char.ToUpper(str[0]) + str.Substring(1);
        //    }
        //    registr = char.ToUpper(str[0]) + str.Substring(1);
        //    //убирает лишние пробелы, оставляется
        //    MessageBox.Show(registr);
        //}

        private void B_Ow_Pet1_Click(object sender, RoutedEventArgs e)
        {
            string registr;
            string text = TB_Phrase_P1.Text;
            //меняет слова местами, первый с последним и убирает лишние пробелы
            string[] mas = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (mas.Length > 1)
            {
                text = "";
                for (int i = 1; i < mas.Length - 1; i++)
                    text += mas[i] + " ";
                text = mas[mas.Length - 1] + " " + text + mas[0];
            }
            //меняет регистр слов, первое слово с заглавной буквы, остальное в нижнем регистре
            var str = text.ToLower();
            if (str.Length > 1)
            {
                text = char.ToUpper(str[0]) + str.Substring(1);
                
            }
            text = char.ToUpper(str[0]) + str.Substring(1);
           
            //убирает лишние пробелы, оставляется
            //registr=TB_Phrase_P1.Text.Replace("  ", " ");
            MessageBox.Show(text);
        }

        private void B_Ow_Dog1_Click(object sender, RoutedEventArgs e)
        {
            string text = TB_Phrase_D1.Text;
            // убирает лишние пробелы
            while (text.Contains("  ")) 
            { 
                text = text.Replace("  ", " "); 
            }
            //Все слова должны быть не больше 12 букв

            string[] words = text.Split(' ');
            text = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 12)
                {
                    words[i] = words[i].Substring(0, 12);
                }
                text += words[i] + " ";
            }


            //меняет регистр слов, первое слово с заглавной буквы, остальное в нижнем регистре
            var str = text.ToLower();
            if (str.Length > 1)
            {
                text = char.ToUpper(str[0]) + str.Substring(1);
                //registr = char.ToUpper(str[0]) + str.Substring(1);
            }
            text = char.ToUpper(str[0]) + str.Substring(1);
            MessageBox.Show(text+" Гав");
        }
        Random rnd=new Random();
        Random rand=new Random();
        private void B_Ow_Cat_Click(object sender, RoutedEventArgs e)
        {
            string text = TB_Phrase_C.Text;
            // убирает лишние пробелы
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            //После двух случайных слов добавить «мяу!» или «мурр» (что добавлять, выбирается случайным образом, в одной фразе присутствует либо мяуканье, либо мурчание)
            //-Нет, просто после двух каких-то слов
            //Например, "Хозяин, покорми меня" можно добавить либо после "хозяин" и "меня", либо после "покорми" и "меня", либо после "хозяин" и "покорми"
            //-то есть если фраза длинная, все равно просто 2 раза используется либо мяу мяу либо мур мур



            string[] words = text.Split(' ');
            text = "";
            List<string> slova = new List<string>(words);
            int x = rnd.Next(0, slova.Count);
            int y = rnd.Next(0, slova.Count);
            string[] meow = new string[] {"мяу!", "мурр"};
            int numMeow=rand.Next(0, meow.Length);
            if (numMeow == 0)
            {
                slova.Insert(x, "мяу!");
                slova.Insert(y, "мяу!");
            }
            else
            { 
                slova.Insert(x, "мурр");
                slova.Insert(y, "мурр"); 
            }
            
            foreach (string item in slova)
            {
                text += item + " ";
            }
            
            //меняет регистр слов, первое слово с заглавной буквы, остальное в нижнем регистре
            var str = text.ToLower();
            if (str.Length > 1)
            {
                text = char.ToUpper(str[0]) + str.Substring(1);
            }
            text = char.ToUpper(str[0]) + str.Substring(1);
            MessageBox.Show(text);
        }
    }
}
