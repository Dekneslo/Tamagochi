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
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Reflection;

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
        private Dog dog = new Dog();
        private Cat cat = new Cat();
        private Pet pet = new Pet();
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
        public void BSafePET_Click(object sender, RoutedEventArgs e)
        {
            //Pet pet = new Pet();
            try
            {
                BCaressPET.IsEnabled = true;
                BPlayPET1.IsEnabled = true;
                BFeedPET1.IsEnabled = true;
                BTrainPET1.IsEnabled = true;
                BPetRelife1.IsEnabled = false;

                string namePet = TBPET_N.Text;
                if (Regex.IsMatch(namePet, @"^^([А-ЯЁ][а-яё]+)(\s[А-ЯЁ][а-яё]+)*$"))
                {
                    pet.Name = namePet;
                }
                else
                {
                    MessageBox.Show("Имя введено неверно");
                }
                string moodPet = TBPet_M.Text;
                string satietyPet = TBPet_S.Text;
                string forcesPet = TBPet_F.Text;
                if (Regex.IsMatch(moodPet, @"^([1-9]|[1-9][0-9]|100)(%\s?|\s?)$") | Regex.IsMatch(satietyPet, @"^([1-9]|[1-9][0-9]|100)(%\s?|\s?)$") | Regex.IsMatch(forcesPet, @"^([1-9]|[1-9][0-9]|100)(%\s?|\s?)$"))
                {
                    string[] moodP = moodPet.Split(' ');
                    if (moodP.Length != 2)
                    {
                        moodP = moodPet.Split('%');
                    }
                    pet.Mood1 = Convert.ToInt32(moodP[0]);

                    string[] satietyP = satietyPet.Split(' ');
                    if (satietyP.Length != 2)
                    {
                        satietyP = satietyPet.Split('%');
                    }
                    pet.Satiety1 = Convert.ToInt32(satietyP[0]);

                    string[] forcesP = forcesPet.Split(' ');
                    if (forcesP.Length != 2)
                    {
                        forcesP = forcesPet.Split('%');
                    }
                    pet.Forces1 = Convert.ToInt32(forcesP[0]);
                }
                else
                {

                    MessageBox.Show("Значение введено неверно");
                }
                string weightPet = TBPet_W.Text;
                if (Regex.IsMatch(weightPet, @"^(?=.*[1-9])\d+(?:,\d{1,2})?(?:\sкг)?$"))
                {
                    string[] weightP = weightPet.Split(' ');
                    pet.Weight1 = Convert.ToInt32(Math.Round(Convert.ToDouble(weightP[0])));
                }
                else
                {
                    MessageBox.Show("Вес введен неверно");
                }
                pet.Fluff = jopa;
                pet.Flufy = int.Parse(LresFluff.Content.ToString());
                pet.Weight = pet.Weight1;
                pet.Mood = pet.Mood1;
                pet.Satiety = pet.Satiety1;
                pet.Forces = pet.Forces1;

                PG_PETM.Value = pet.Mood;
                PG_PETS.Value = pet.Satiety;
                PG_PETF.Value = pet.Forces;
                PG_PETW.Value = pet.Weight;

                PG_PETM.Maximum = Convert.ToDouble(PG_PETMax.Text);
                PG_PETS.Maximum = Convert.ToDouble(PG_PETMax.Text);
                PG_PETF.Maximum = Convert.ToDouble(PG_PETMax.Text);


                a = pet.Weight;
                b = pet.Mood;
                c = pet.Satiety;
                d = pet.Forces;

                L1.Content += "" + a;
                L2.Content += "" + b;
                L3.Content += "" + c;
                L4.Content += "" + d;

                x = pet.Mood;
                y = pet.Satiety;
                z = pet.Forces;
                f = pet.Weight;
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
                int x = pet.Mood;
                int z = pet.Forces;

                pet.Caress(x, z);

                PG_PETM.Value = pet.Mood;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + pet.Mood;
                TBPet_F.Text = "" + pet.Forces;
                Gachi.Add(pet);
                if (x <= 0 | z <= 0)
                {
                    BCaressPET.IsEnabled = false;
                    BPlayPET1.IsEnabled = false;
                    BFeedPET1.IsEnabled = false;
                    BTrainPET1.IsEnabled = false;
                }
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
                x = pet.Mood;
                z = pet.Forces;

                pet.Caress(x, z);

                PG_PETM.Value = pet.Mood;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + pet.Mood;
                TBPet_F.Text = "" + pet.Forces;
            }
        }
        private void BPlayPET1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = pet.Mood;
                int y = pet.Satiety;
                int z = pet.Forces;
                pet.Smert1 = pet.Mood;
                pet.Smert2 = pet.Satiety;
                pet.Smert3 = pet.Forces;
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
                if (x <= 0 | y <= 0 | z <= 0)
                {
                    BCaressPET.IsEnabled = false;
                    BPlayPET1.IsEnabled = false;
                    BFeedPET1.IsEnabled = false;
                    BTrainPET1.IsEnabled = false;
                }
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
                x = pet.Mood;
                y = pet.Satiety;
                z = pet.Forces;

                pet.Play(x, y, z);

                PG_PETM.Value = pet.Mood;
                PG_PETS.Value = pet.Satiety;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + (PG_PETM.Value);
                TBPet_S.Text = "" + (PG_PETS.Value);
                TBPet_F.Text = "" + (PG_PETF.Value);
                
                if (PG_PETM.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BPetRelife1.IsEnabled = true;
                    BCaressPET.IsEnabled = false;
                    BPlayPET1.IsEnabled = false;
                    BFeedPET1.IsEnabled = false;
                    BTrainPET1.IsEnabled = false;
                }
                else
                {
                    PG_PETM.Value += 0;
                }
                if (PG_PETS.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BPetRelife1.IsEnabled = true;
                    BCaressPET.IsEnabled = false;
                    BPlayPET1.IsEnabled = false;
                    BFeedPET1.IsEnabled = false;
                    BTrainPET1.IsEnabled = false;
                }
                else
                {
                    PG_PETS.Value += 0;
                }
                if (PG_PETF.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BPetRelife1.IsEnabled = true;
                    BCaressPET.IsEnabled = false;
                    BPlayPET1.IsEnabled = false;
                    BFeedPET1.IsEnabled = false;
                    BTrainPET1.IsEnabled = false;
                }
                else
                {
                    PG_PETF.Value += 0;
                }

            }
        }

        private void BFeedPET1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int f = pet.Weight;
                int y = pet.Satiety;
                pet.Feed(y, f, f);
                PG_PETS.Value = pet.Satiety;
                PG_PETW.Value = pet.Weight;

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
                f = pet.Weight;
                y = pet.Satiety;
                pet.Feed(y, f, f);

                PG_PETS.Value = pet.Satiety;
                PG_PETW.Value = pet.Weight;

                TBPet_W.Text = "" + (PG_PETW.Value);
                TBPet_S.Text = "" + (PG_PETS.Value);

            }
        }

        private void BTrainPET1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = pet.Mood;
                int y = pet.Satiety;
                int z = pet.Forces;
                pet.Smert1 = pet.Mood;
                pet.Smert2 = pet.Satiety;
                pet.Smert3 = pet.Forces;
                pet.Testing1 = b;
                pet.Testing2 = c;
                pet.Testing3 = d;

                pet.Train(x, y, z);

                if (pet.Smert1 <= 0)
                {
                    BPetRelife1.IsEnabled = true;
                }
                if (pet.Smert2 <= 0)
                {
                    BPetRelife1.IsEnabled = true;
                }
                if (pet.Smert3 <= 0)
                {
                    BPetRelife1.IsEnabled = true;
                }

                PG_PETM.Value = pet.Mood;
                PG_PETS.Value = pet.Satiety;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + pet.Mood;
                TBPet_S.Text = "" + pet.Satiety;
                TBPet_F.Text = "" + pet.Forces;
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
                x = pet.Mood;
                y = pet.Satiety;
                z = pet.Forces;
                pet.Train(x, y, z);

                PG_PETM.Value = pet.Mood;
                PG_PETS.Value = pet.Satiety;
                PG_PETF.Value = pet.Forces;

                TBPet_M.Text = "" + (PG_PETM.Value);
                TBPet_S.Text = "" + (PG_PETS.Value);
                TBPet_F.Text = "" + (PG_PETF.Value);
                if (PG_PETM.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BPetRelife1.IsEnabled = true;
                    BCaressPET.IsEnabled = false;
                    BPlayPET1.IsEnabled = false;
                    BFeedPET1.IsEnabled = false;
                    BTrainPET1.IsEnabled = false;
                }
                else
                {
                    PG_PETM.Value += 0;
                }
                if (PG_PETS.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BPetRelife1.IsEnabled = true;
                    BCaressPET.IsEnabled = false;
                    BPlayPET1.IsEnabled = false;
                    BFeedPET1.IsEnabled = false;
                    BTrainPET1.IsEnabled = false;
                }
                else
                {
                    PG_PETS.Value += 0;
                }
                if (PG_PETF.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BPetRelife1.IsEnabled = true;
                    BCaressPET.IsEnabled = false;
                    BPlayPET1.IsEnabled = false;
                    BFeedPET1.IsEnabled = false;
                    BTrainPET1.IsEnabled = false;
                }
                else
                {
                    PG_PETF.Value += 0;
                }
            }
        }


        int schetpopitokPet = 0;
        private void BPetRelife1_Click(object sender, RoutedEventArgs e)
        {
            BSafePET.IsEnabled = true;

            BCaressPET.IsEnabled = true;
            BPlayPET1.IsEnabled = true;
            BFeedPET1.IsEnabled = true;
            BTrainPET1.IsEnabled = true;

            schetpopitokPet++;
            MessageBox.Show($"Игр сыграно: {schetpopitokPet}");

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

            //Число попыток при игре
            //Popitki.Content = "";
            //Popitki.Content = "" + schetpopitokPet;
            L1.Content = "";
            L2.Content = "";
            L3.Content = "";
            L4.Content = "";

            //сделать лист и каунт в массиве, в лист записывается 1, каунт считает сколько их там
            List<int> ListPopitok = new List<int>();
            if (BPetRelife1.IsEnabled == true)
            {
                ListPopitok.Add(1);
            }
            //в кнопке инфо или показать попытки:
            int popitki = ListPopitok.Count;
            Popitki.Content = popitki;
            //popitki += 1;
            //Popitki.Content= popitki;
        }

        public void BSafeDOG_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BCaressDOG1.IsEnabled = true;
                BPlayDOG2.IsEnabled = true;
                BFeedDOG.IsEnabled = true;
                BTrainDOG1.IsEnabled = true;
                BDogRelife1.IsEnabled = false;

                string nameDog = TBDOG_N.Text;
                if (!Regex.IsMatch(nameDog, @"^^([А-ЯЁ][а-яё]+)(\s[А-ЯЁ][а-яё]+)*$"))
                {
                    MessageBox.Show("Имя введено неверно");
                }
                else
                {
                    dog.Name = nameDog;
                }
                string moodDog = TBDog_M.Text;
                string satietyDog = TBDog_S.Text;
                string forcesDog = TBDog_F.Text;
                if (Regex.IsMatch(moodDog, @"^([1-9]|[1-9][0-9]|100)(%\s?|\s?)$") | Regex.IsMatch(satietyDog, @"^([1-9]|[1-9][0-9]|100)(%\s?|\s?)$") | Regex.IsMatch(forcesDog, @"^([1-9]|[1-9][0-9]|100)(%\s?|\s?)$"))
                {
                    string[] moodD = moodDog.Split(' ');
                    if (moodD.Length != 2)
                    {
                        moodD = moodDog.Split('%');
                    }
                    dog.Mood1 = Convert.ToInt32(moodD[0]);

                    string[] satietyD = satietyDog.Split(' ');
                    if (satietyD.Length != 2)
                    {
                        satietyD = satietyDog.Split('%');
                    }
                    dog.Satiety1 = Convert.ToInt32(satietyD[0]);

                    string[] forcesD = forcesDog.Split(' ');
                    if (forcesD.Length != 2)
                    {
                        forcesD = forcesDog.Split('%');
                    }
                    dog.Forces1 = Convert.ToInt32(forcesD[0]);
                }
                else
                {
                    MessageBox.Show("Значение введено неверно");
                }
                string weightDog = TBDog_W.Text;
                if (Regex.IsMatch(weightDog, @"^(?=.*[1-9])\d+(?:,\d{1,2})?(?:\sкг)?$"))
                {
                    string[] weightD = weightDog.Split(' ');
                    dog.Weight1 = Convert.ToInt32(Math.Round(Convert.ToDouble(weightD[0])));
                }
                else
                {
                    MessageBox.Show("Вес введен неверно");
                }

                dog.Fluff = jopa;
                dog.Flufy = int.Parse(LresFluff.Content.ToString());
                dog.Weight = dog.Weight1;
                dog.Mood = dog.Mood1;
                dog.Satiety = dog.Satiety1;
                dog.Forces = dog.Forces1;

                PG_DOGW.Value = dog.Weight;
                PG_DOGM.Value = dog.Mood;
                PG_DOGS.Value = dog.Satiety;
                PG_DOGF.Value = dog.Forces;

                PG_DOGM.Maximum = Convert.ToDouble(PG_DOGMax.Text);
                PG_DOGS.Maximum = Convert.ToDouble(PG_DOGMax.Text);
                PG_DOGF.Maximum = Convert.ToDouble(PG_DOGMax.Text);

                g = dog.Weight;
                h = dog.Mood;
                i = dog.Satiety;
                j = dog.Forces;

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
                int x = dog.Mood;
                int z = dog.Forces;
                dog.Caress(x, z);
                PG_DOGM.Value = dog.Mood;
                PG_DOGF.Value = dog.Forces;

                TBDog_M.Text = "" + (PG_DOGM.Value);
                TBDog_F.Text = "" + (PG_DOGF.Value);
                //Gachi.Add(dog);\
                Dachi.Add(dog);
                if (x <= 0 | z <= 0)
                {
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
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
                x = dog.Mood;
                z = dog.Forces;

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
                //Dog dog = new Dog();
                int x = dog.Mood;
                int y = dog.Satiety;
                int z = dog.Forces;
                dog.Testing1 = h;
                dog.Testing2 = i;
                dog.Testing3 = j;
                dog.Smert1 = dog.Mood;
                dog.Smert2 = dog.Satiety;
                dog.Smert3 = dog.Forces;
                dog.Play(x, y, z);

                if (dog.Smert1 <= 0)
                {
                    BDogRelife1.IsEnabled = true;
                }
                if (dog.Smert2 <= 0)
                {
                    BDogRelife1.IsEnabled = true;
                }
                if (dog.Smert3 <= 0)
                {
                    BDogRelife1.IsEnabled = true;
                }

                PG_DOGM.Value = dog.Mood;
                PG_DOGS.Value = dog.Satiety;
                PG_DOGF.Value = dog.Forces;

                TBDog_M.Text = "" + (PG_DOGM.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
                TBDog_F.Text = "" + (PG_DOGF.Value);
                Dachi.Add(dog);
                if (x <= 0 | y <= 0 | z <= 0)
                {
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
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
                x = dog.Mood;
                y = dog.Satiety;
                z = dog.Forces;

                dog.Play(x, y, z);

                PG_DOGM.Value = dog.Mood;
                PG_DOGS.Value = dog.Satiety;
                PG_DOGF.Value = dog.Forces;

                TBDog_M.Text = "" + (PG_DOGM.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
                TBDog_F.Text = "" + (PG_DOGF.Value);
                if (PG_DOGM.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BDogRelife1.IsEnabled = true;
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
                else
                {
                    PG_DOGM.Value += 0;
                }
                if (PG_DOGS.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BDogRelife1.IsEnabled = true;
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
                else
                {
                    PG_DOGS.Value += 0;
                }
                if (PG_DOGF.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BDogRelife1.IsEnabled = true;
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
                else
                {
                    PG_DOGF.Value += 0;
                }
            }
        }

        private void BFeedDOG_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = dog.Mood;
                int f = dog.Weight;
                int y = dog.Satiety;
                dog.Feed(x, y, f);

                PG_DOGW.Value = dog.Weight;
                PG_DOGM.Value = dog.Mood;
                PG_DOGS.Value = dog.Satiety;

                TBDog_W.Text = "" + (PG_DOGW.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
                TBDog_M.Text = "" + (PG_DOGM.Value);
                //Gachi.Add(dog);
                Dachi.Add(dog);
                if (y <= 0)
                {
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
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
                x = dog.Mood;
                f = dog.Weight;
                y = dog.Satiety;
                dog.Feed(x, y, f);

                PG_DOGW.Value = dog.Weight;
                PG_DOGM.Value = dog.Mood;
                PG_DOGS.Value = dog.Satiety;

                TBDog_W.Text = "" + (PG_DOGW.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
                TBDog_M.Text = "" + (PG_DOGM.Value);
            }
        }

        private void BTrainDOG1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = dog.Mood;
                int y = dog.Satiety;
                int z = dog.Forces;
                dog.Testing1 = h;
                dog.Testing2 = i;
                dog.Testing3 = j;
                dog.Smert1 = dog.Mood;
                dog.Smert2 = dog.Satiety;
                dog.Smert3 = dog.Forces;
                dog.Train(x, y, z);

                if (dog.Smert1 <= 0)
                {
                    BDogRelife1.IsEnabled = true;
                }
                if (dog.Smert2 <= 0)
                {
                    BDogRelife1.IsEnabled = true;
                }
                if (dog.Smert3 <= 0)
                {
                    BDogRelife1.IsEnabled = true;
                }

                PG_DOGM.Value = dog.Mood;
                PG_DOGS.Value = dog.Satiety;
                PG_DOGF.Value = dog.Forces;

                TBDog_M.Text = "" + (PG_DOGM.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
                TBDog_F.Text = "" + (PG_DOGF.Value);
                //Gachi.Add(dog);
                Dachi.Add(dog);
                if (x <= 0 | y <= 0 | z <= 0)
                {
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
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
                x = dog.Mood;
                y = dog.Satiety;
                z = dog.Forces;
                dog.Train(x, y, z);

                PG_DOGM.Value = dog.Mood;
                PG_DOGS.Value = dog.Satiety;
                PG_DOGF.Value = dog.Forces;

                TBDog_M.Text = "" + (PG_DOGM.Value);
                TBDog_S.Text = "" + (PG_DOGS.Value);
                TBDog_F.Text = "" + (PG_DOGF.Value);
                if (PG_DOGM.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BDogRelife1.IsEnabled = true;
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
                else
                {
                    PG_DOGM.Value += 0;
                }
                if (PG_DOGS.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BDogRelife1.IsEnabled = true;
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
                else
                {
                    PG_DOGS.Value += 0;
                }
                if (PG_DOGF.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BDogRelife1.IsEnabled = true;
                    BCaressDOG1.IsEnabled = false;
                    BPlayDOG2.IsEnabled = false;
                    BFeedDOG.IsEnabled = false;
                    BTrainDOG1.IsEnabled = false;
                }
                else
                {
                    PG_DOGF.Value += 0;
                }
            }
        }

        int schetpopitokDog = 0;
        private void BDogRelife1_Click(object sender, RoutedEventArgs e)
        {
            BSafeDOG.IsEnabled = true;

            BCaressDOG1.IsEnabled = true;
            BPlayDOG2.IsEnabled = true;
            BFeedDOG.IsEnabled = true;
            BTrainDOG1.IsEnabled = true;

            schetpopitokDog++;
            MessageBox.Show($"Игр сыграно: {schetpopitokDog}");

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
            try
            {
                BCaressCAT1.IsEnabled = true;
                BPlayCAT1.IsEnabled = true;
                BFeedCAT1.IsEnabled = true;
                BTrainCAT1.IsEnabled = true;
                BCatRelife1.IsEnabled = false;

                string nameCat = TBCAT_N.Text;
                if (!Regex.IsMatch(nameCat, @"^([А-ЯЁ][а-яё]+)(\s[А-ЯЁ][а-яё]+)*$"))//в скобках фигурных 2 типо повторений два но как между ними пробел?
                {
                    MessageBox.Show("Имя введено неверно");
                }
                else
                {
                    cat.Name = nameCat;
                }
                string moodCat = TBCat_M.Text;
                string satietyCat = TBCat_S.Text;
                string forcesCat = TBCat_F.Text;
                if (Regex.IsMatch(moodCat, @"^([1-9]|[1-9][0-9]|100)(%\s?|\s?)$") | Regex.IsMatch(satietyCat, @"^([1-9]|[1-9][0-9]|100)(%\s?|\s?)$") | Regex.IsMatch(forcesCat, @"^([1-9]|[1-9][0-9]|100)(%\s?|\s?)$"))
                {
                    string[] moodC = moodCat.Split(' ');
                    if (moodC.Length != 2)
                    {
                        moodC = moodCat.Split('%');
                    }
                    cat.Mood1 = Convert.ToInt32(moodC[0]);

                    string[] satietyC = satietyCat.Split(' ');
                    if (satietyC.Length != 2)
                    {
                        satietyC = satietyCat.Split('%');
                    }
                    cat.Satiety1 = Convert.ToInt32(satietyC[0]);

                    string[] forcesC = forcesCat.Split(' ');
                    if (forcesC.Length != 2)
                    {
                        forcesC = forcesCat.Split('%');
                    }
                    cat.Forces1 = Convert.ToInt32(forcesC[0]);
                }
                else
                {
                    MessageBox.Show("Значение введено неверно");

                }
                string weightCat = TBCat_W.Text;
                if (Regex.IsMatch(weightCat, @"^(?=.*[1-9])\d+(?:,\d{1,2})?(?:\sкг)?$"))
                {
                    string[] weightC = weightCat.Split(' ');
                    cat.Weight1 = Convert.ToInt32(Math.Round(Convert.ToDouble(weightC[0])));
                }
                else
                {
                    MessageBox.Show("Вес введен неверно");
                }

                cat.Fluff = jopa;
                cat.Flufy = int.Parse(LresFluff.Content.ToString());
                cat.Weight = cat.Weight1;
                cat.Mood = cat.Mood1;
                cat.Satiety = cat.Satiety1;
                cat.Forces = cat.Forces1;

                PG_CATW.Value = cat.Weight;
                PG_CATM.Value = cat.Mood;
                PG_CATS.Value = cat.Satiety;
                PG_CATF.Value = cat.Forces;

                PG_CATM.Maximum = Convert.ToDouble(PG_CATMax.Text);
                PG_CATS.Maximum = Convert.ToDouble(PG_CATMax.Text);
                PG_CATF.Maximum = Convert.ToDouble(PG_CATMax.Text);

                k = cat.Weight;
                l = cat.Mood;
                m = cat.Satiety;
                n = cat.Forces;

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
            //ЕСЛИ УБРАТЬ ПОСЛЕДНИЙ ЕХ ТО ВЕС С ЗНАКАМИ ПОСЛЕ ЗАПЯТОЙ НЕ ПОРЙДЕТ ИЗ ЗА ТИПА ДАБЛ А ТАМ ПРЕОБРАЗОВАНИЕ В ИНТ
        }


        private void BCaressCAT1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = cat.Mood;
                int z = cat.Forces;
                cat.Caress(x, z);

                PG_CATM.Value = cat.Mood;
                PG_CATF.Value = cat.Forces;

                TBCat_M.Text = "" + (PG_CATM.Value);
                TBCat_F.Text = "" + (PG_CATF.Value);
                Cachi.Add(cat);
                if (x <= 0 | z <= 0)
                {
                    BCaressCAT1.IsEnabled = false;
                    BPlayCAT1.IsEnabled = false;
                    BFeedCAT1.IsEnabled = false;
                    BTrainCAT1.IsEnabled = false;
                }
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
                x = cat.Mood;
                z = cat.Forces;

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
                int x = cat.Mood;
                int y = cat.Satiety;
                int z = cat.Forces;
                cat.Testing1 = l;
                cat.Testing2 = m;
                cat.Testing3 = n;
                cat.Smert1 = cat.Mood;
                cat.Smert2 = cat.Satiety;
                cat.Smert3 = cat.Forces;
                cat.Play(x, y, z);

                if (cat.Smert1 <= 0)
                {
                    BCatRelife1.IsEnabled = true;
                }
                if (cat.Smert2 <= 0)
                {
                    BCatRelife1.IsEnabled = true;
                }
                if (cat.Smert3 <= 0)
                {
                    BCatRelife1.IsEnabled = true;
                }

                PG_CATM.Value = cat.Mood;
                PG_CATS.Value = cat.Satiety;
                PG_CATF.Value = cat.Forces;

                TBCat_M.Text = "" + (PG_CATM.Value);
                TBCat_S.Text = "" + (PG_CATS.Value);
                TBCat_F.Text = "" + (PG_CATF.Value);
                Cachi.Add(cat);
                if (x <= 0 | y <= 0 | z <= 0)
                {
                    BCaressCAT1.IsEnabled = false;
                    BPlayCAT1.IsEnabled = false;
                    BFeedCAT1.IsEnabled = false;
                    BTrainCAT1.IsEnabled = false;
                }
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
                x = cat.Mood;
                y = cat.Satiety;
                z = cat.Forces;

                cat.Play(x, y, z);

                PG_CATM.Value = cat.Mood;
                PG_CATS.Value = cat.Satiety;
                PG_CATF.Value = cat.Forces;

                TBCat_M.Text = "" + (PG_CATM.Value);
                TBCat_S.Text = "" + (PG_CATS.Value);
                TBCat_F.Text = "" + (PG_CATF.Value);
                if (PG_CATM.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BCatRelife1.IsEnabled = true;
                    BCaressCAT1.IsEnabled = false;
                    BPlayCAT1.IsEnabled = false;
                    BFeedCAT1.IsEnabled = false;
                    BTrainCAT1.IsEnabled = false;
                }
                else
                {
                    PG_CATM.Value += 0;
                }
                if (PG_CATS.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BCatRelife1.IsEnabled = true;
                    BCaressCAT1.IsEnabled = false;
                    BPlayCAT1.IsEnabled = false;
                    BFeedCAT1.IsEnabled = false;
                    BTrainCAT1.IsEnabled = false;
                }
                else
                {
                    PG_CATS.Value += 0;
                }
                if (PG_CATF.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BCatRelife1.IsEnabled = true;
                    BCaressCAT1.IsEnabled = false;
                    BPlayCAT1.IsEnabled = false;
                    BFeedCAT1.IsEnabled = false;
                    BTrainCAT1.IsEnabled = false;
                }
                else
                {
                    PG_CATF.Value += 0;
                }
            }
        }

        private void BFeedCAT1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int f = cat.Weight;
                int x = cat.Mood;
                cat.Feed(x, f, f);

                if (cat.Smert2 <= 0)
                {
                    BCatRelife1.IsEnabled = true;
                }

                PG_CATW.Value = cat.Weight;
                PG_CATM.Value = cat.Mood;

                TBCat_W.Text = "" + (PG_CATW.Value);
                TBCat_M.Text = "" + (PG_CATM.Value);
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
                f = cat.Weight;
                x = cat.Mood;
                cat.Feed(x, y, f);

                PG_CATW.Value = cat.Weight;
                PG_CATM.Value = cat.Mood;

                TBCat_W.Text = "" + (PG_CATW.Value);
                TBCat_M.Text = "" + (PG_CATM.Value);
            }
        }

        private void BTrainCAT1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = cat.Mood;
                int y = cat.Satiety;
                int z = cat.Forces;
                cat.Testing1 = l;
                cat.Testing2 = m;
                cat.Testing3 = n;

                cat.Smert1 = cat.Mood;
                cat.Smert2 = cat.Satiety;
                cat.Smert3 = cat.Forces;  
                cat.Train(x, y, z);


                PG_CATM.Value = cat.Mood;
                PG_CATS.Value = cat.Satiety;
                PG_CATF.Value = cat.Forces;
           
                TBCat_M.Text = "" + (PG_CATM.Value);
                TBCat_S.Text = "" + (PG_CATS.Value);
                TBCat_F.Text = "" + (PG_CATF.Value);
                Cachi.Add(cat);
                if (x <= 0 | y <= 0 | z <= 0)
                {
                    BCaressCAT1.IsEnabled = false;
                    BPlayCAT1.IsEnabled = false;
                    BFeedCAT1.IsEnabled = false;
                    BTrainCAT1.IsEnabled = false;
                }
                cat.Smert1 = cat.Mood;
                cat.Smert2 = cat.Satiety;
                cat.Smert3 = cat.Forces;
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
                x = cat.Mood;
                y = cat.Satiety;
                z = cat.Forces;
                cat.Train(x, y, z);
                PG_CATM.Value = cat.Mood;
                PG_CATS.Value = cat.Satiety;
                PG_CATF.Value = cat.Forces;

                TBCat_M.Text = "" + (PG_CATM.Value);
                TBCat_S.Text = "" + (PG_CATS.Value);
                TBCat_F.Text = "" + (PG_CATF.Value);
                
                if (PG_CATM.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BCatRelife1.IsEnabled = true;
                    BCaressCAT1.IsEnabled = false;
                    BPlayCAT1.IsEnabled = false;
                    BFeedCAT1.IsEnabled = false;
                    BTrainCAT1.IsEnabled = false;
                }
                else
                {
                    PG_CATM.Value += 0;
                }
                if (PG_CATS.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BCatRelife1.IsEnabled = true;
                    BCaressCAT1.IsEnabled = false;
                    BPlayCAT1.IsEnabled = false;
                    BFeedCAT1.IsEnabled = false;
                    BTrainCAT1.IsEnabled = false;
                }
                else
                {
                    PG_CATS.Value += 0;
                }
                if (PG_CATF.Value <= 0)
                {
                    MessageBox.Show("Он сдох >:(");
                    BCatRelife1.IsEnabled = true;
                    BCaressCAT1.IsEnabled = false;
                    BPlayCAT1.IsEnabled = false;
                    BFeedCAT1.IsEnabled = false;
                    BTrainCAT1.IsEnabled = false;
                }
                else
                {
                    PG_CATF.Value += 0;
                }
            }
        }


        int schetpopitokCat = 0;
        private void BCatRelife1_Click(object sender, RoutedEventArgs e)
        {

            BSafeCAT.IsEnabled = true;

            BCaressCAT1.IsEnabled = true;
            BPlayCAT1.IsEnabled = true;
            BFeedCAT1.IsEnabled = true;
            BTrainCAT1.IsEnabled = true;

            schetpopitokCat++;
            MessageBox.Show($"Игр сыграно: {schetpopitokCat}");

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

                        TRES.Foreground = Brushes.Black;

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
                            PG_PETFL.Value = pet.Flufy;
                            jopa = "Лысый";
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Fluff = "Лысый";
                            dog.Sherst1();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value = dog.Flufy;
                            jopa = "Лысый";
                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Fluff = "Лысый";
                            cat.Sherst1();
                            LresFluff.Content = cat.Flufy;
                            PG_CATFL.Value = cat.Flufy;
                            jopa = "Лысый";
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
                            jopa = "Короткошерстный";
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Sherst2();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value = dog.Flufy;
                            dog.Fluff = "Короткошерстный";
                            jopa = "Короткошерстный";
                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Sherst2();
                            LresFluff.Content = cat.Flufy;
                            PG_CATFL.Value = cat.Flufy;
                            cat.Fluff = "Короткошерстный";
                            jopa = "Короткошерстный";
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
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Sherst3();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value = dog.Flufy;
                            dog.Fluff = "Среднешерстный";
                            jopa = "Среднешерстный";
                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Sherst3();
                            LresFluff.Content = cat.Flufy;
                            PG_CATFL.Value = cat.Flufy;
                            cat.Fluff = "Среднешерстный";
                            jopa = "Среднешерстный";
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
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Sherst4();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value = dog.Flufy;
                            dog.Fluff = "Длинношерстный";
                            jopa = "Длинношерстный";
                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Sherst4();
                            LresFluff.Content = cat.Flufy;
                            PG_CATFL.Value = cat.Flufy;
                            cat.Fluff = "Длинношерстный";
                            jopa = "Длинношерстный";
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
                        }
                        else if (Canvas2.Visibility == Visibility.Visible)
                        {
                            dog.Sherst5();
                            LresFluff.Content = dog.Flufy;
                            PG_DOGFL.Value = dog.Flufy;
                            dog.Fluff = "Кудрявый";
                            jopa = "Кудрявый";

                        }
                        else if (Canvas3.Visibility == Visibility.Visible)
                        {
                            cat.Sherst5();
                            LresFluff.Content = pet.Flufy;
                            PG_CATFL.Value = cat.Flufy;
                            cat.Fluff = "Кудрявый";
                            jopa = "Кудрявый";

                        }
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
            L1.Content = "";
            L2.Content = "";
            L3.Content = "";
            L4.Content = "";
        }
        private void Trash2_Click(object sender, RoutedEventArgs e)
        {
            TBDOG_N.Text = "";
            TBDog_W.Text = "";
            TBDog_M.Text = "";
            TBDog_S.Text = "";
            TBDog_F.Text = "";
            PG_DOGMax.Text = "";
            PG_DOGW.Value = 0;
            PG_DOGM.Value = 0;
            PG_DOGS.Value = 0;
            PG_DOGF.Value = 0;
            PG_DOGFL.Value = 0;
            L5.Content = "";
            L6.Content = "";
            L7.Content = "";
            L8.Content = "";
        }
        private void Trash3_Click(object sender, RoutedEventArgs e)
        {
            TBCAT_N.Text = "";
            TBCat_W.Text = "";
            TBCat_M.Text = "";
            TBCat_S.Text = "";
            TBCat_F.Text = "";
            PG_CATMax.Text = "";
            PG_CATW.Value = 0;
            PG_CATM.Value = 0;
            PG_CATS.Value = 0;
            PG_CATF.Value = 0;
            PG_CATFL.Value = 0;
            L9.Content = "";
            L10.Content = "";
            L11.Content = "";
            L12.Content = "";
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            Pet pet = new Pet();
            pet.Weight = Convert.ToInt32(TBPet_W.Text);
            pet.Mood = Convert.ToInt32(TBPet_M.Text);
            pet.Satiety = Convert.ToInt32(TBPet_S.Text);
            pet.Forces = Convert.ToInt32(TBPet_F.Text);
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

            foreach (Pet i in Gachi)
            {
                sum2 += i.Mood;
            }

            foreach (Pet i in Gachi)
            {
                sum3 += i.Satiety;
            }

            foreach (Pet i in Gachi)
            {
                sum4 += i.Forces;
            }

            foreach (Pet i in Gachi)
            {
                sum5 += i.Flufy;
            }



            foreach (Dog d in Dachi)
            {
                sum6 += d.Weight;
            }

            foreach (Dog d in Dachi)
            {
                sum7 += d.Mood;
            }

            foreach (Dog d in Dachi)
            {
                sum8 += d.Satiety;
            }

            foreach (Dog d in Dachi)
            {
                sum9 += d.Forces;
            }

            foreach (Dog d in Dachi)
            {
                sum10 += d.Flufy;
            }



            foreach (Cat c in Cachi)
            {
                sum11 += c.Weight;
            }
            foreach (Cat c in Cachi)
            {
                sum12 += c.Mood;
            }
            foreach (Cat c in Cachi)
            {
                sum13 += c.Satiety;
            }
            foreach (Cat c in Cachi)
            {
                sum14 += c.Forces;
            }
            foreach (Cat c in Cachi)
            {
                sum15 += c.Flufy;
            }

            double sumW = sum1 + sum6 + sum11;
            double sumM = sum2 + sum7 + sum12;
            double sumS = sum3 + sum8 + sum13;
            double sumF = sum4 + sum9 + sum14;
            double sumFL = sum5 + sum10 + sum15;

            double avgW = (double)sumW / (Gachi.Count + Dachi.Count + Cachi.Count);
            double avgM = (double)sumM / (Gachi.Count + Dachi.Count + Cachi.Count);
            double avgS = (double)sumS / (Gachi.Count + Dachi.Count + Cachi.Count);
            double avgF = (double)sumF / (Gachi.Count + Dachi.Count + Cachi.Count);
            double avgFL = (double)sumFL / (Gachi.Count + Dachi.Count + Cachi.Count);


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


            LRESCount.Content += "Ср.зн. Веса" + " " + avgW + " " + "Медиана" + " " + medianW + "\n" +
            "Ср.зн. Настроения" + " " + avgM + " " + "Медиана" + " " + medianM + "\n" +
            "Ср.зн. Сытости" + " " + avgS + " " + "Медиана" + " " + medianS + "\n" +
            "Ср.зн. Силы" + " " + avgF + " " + "Медиана" + " " + medianF + "\n" +
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

        private void B_Ow_Pet1_Click(object sender, RoutedEventArgs e)
        {
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
            }
            text = char.ToUpper(str[0]) + str.Substring(1);
            MessageBox.Show(text + " Гав");
        }
        Random rnd = new Random();
        Random rand = new Random();
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
            string[] meow = new string[] { "мяу!", "мурр" };
            int numMeow = rand.Next(0, meow.Length);
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

        private void Choose_B_Click_1(object sender, RoutedEventArgs e)
        {
            Random RndSel = new Random();
            int index = RndSel.Next(0, 3);
            if (CHB_Pet.IsChecked == true)
            {
                Canvas1.Visibility = Visibility.Visible;
                Canvas2.Visibility = Visibility.Collapsed;
                Canvas3.Visibility = Visibility.Collapsed;
            }
            if (CHB_Dog.IsChecked == true)
            {
                Canvas2.Visibility = Visibility.Visible;
                Canvas1.Visibility = Visibility.Collapsed;
                Canvas3.Visibility = Visibility.Collapsed;
            }
            if (CHB_Cat.IsChecked == true)
            {
                Canvas3.Visibility = Visibility.Visible;
                Canvas2.Visibility = Visibility.Collapsed;
                Canvas1.Visibility = Visibility.Collapsed;
            }
            if (CHB_Pet.IsChecked == true & CHB_Dog.IsChecked == true)
            {
                if (index == 0)
                {
                    Canvas1.Visibility = Visibility.Visible;
                    Canvas2.Visibility = Visibility.Collapsed;
                    Canvas3.Visibility = Visibility.Collapsed;
                }
                else if (index == 1)
                {
                    Canvas2.Visibility = Visibility.Visible;
                    Canvas1.Visibility = Visibility.Collapsed;
                    Canvas3.Visibility = Visibility.Collapsed;
                }
            }
            else if (CHB_Pet.IsChecked == true & CHB_Dog.IsChecked == true)
            {
                if (index == 0)
                {
                    Canvas1.Visibility = Visibility.Visible;
                    Canvas2.Visibility = Visibility.Collapsed;
                    Canvas3.Visibility = Visibility.Collapsed;
                }
                else if (index == 1)
                {
                    Canvas2.Visibility = Visibility.Visible;
                    Canvas1.Visibility = Visibility.Collapsed;
                    Canvas3.Visibility = Visibility.Collapsed;
                }
            }
            else if (CHB_Dog.IsChecked == true & CHB_Cat.IsChecked == true)
            {
                if (index == 1)
                {
                    Canvas2.Visibility = Visibility.Visible;
                    Canvas1.Visibility = Visibility.Collapsed;
                    Canvas3.Visibility = Visibility.Collapsed;
                }
                else if (index == 2)
                {
                    Canvas3.Visibility = Visibility.Visible;
                    Canvas2.Visibility = Visibility.Collapsed;
                    Canvas1.Visibility = Visibility.Collapsed;
                }
            }
            else if (CHB_Pet.IsChecked == true & CHB_Cat.IsChecked == true)
            {
                if (index == 0)
                {
                    Canvas1.Visibility = Visibility.Visible;
                    Canvas2.Visibility = Visibility.Collapsed;
                    Canvas3.Visibility = Visibility.Collapsed;
                }
                else if (index == 2)
                {
                    Canvas3.Visibility = Visibility.Visible;
                    Canvas2.Visibility = Visibility.Collapsed;
                    Canvas1.Visibility = Visibility.Collapsed;
                }
            }
            else if (CHB_Pet.IsChecked == true & CHB_Dog.IsChecked == true & CHB_Cat.IsChecked == true)
            {
                if (index == 0)
                {
                    Canvas1.Visibility = Visibility.Visible;
                    Canvas2.Visibility = Visibility.Collapsed;
                    Canvas3.Visibility = Visibility.Collapsed;
                }
                else if (index == 1)
                {
                    Canvas2.Visibility = Visibility.Visible;
                    Canvas1.Visibility = Visibility.Collapsed;
                    Canvas3.Visibility = Visibility.Collapsed;
                }
                else if (index == 2)
                {
                    Canvas3.Visibility = Visibility.Visible;
                    Canvas2.Visibility = Visibility.Collapsed;
                    Canvas1.Visibility = Visibility.Collapsed;
                }
            }
        }

    }
}
//3) Питомец может сделать деад но если он умер, то появляется не сообщение о том что он умер, а о том что может умереть
//4) Число попыток при игре реализовать









//1) Проверить регулярку по имени. Не могу ввести 1 слово, только 2
//^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$
//где:
//^-начало строки
//([A - Z][a - z] +) -первое слово, которое начинается с заглавной буквы, за которым следует один или более символов в нижнем регистре
//(\s[A-Z][a-z] +)*-ноль или более групп, содержащих пробел и слово с заглавной первой буквой и остальными строчными буквами
//$ - конец строки


//2) Проверить ввод данных для веса, если после запятой есть знаки. Тип дабл
//^(?=.*[1-9])\d+(?:,\d{1,2})?(?:\sкг)?$




//private List<int> selectedPets = new List<int>();


//private void CheckBox_Checked(object sender, RoutedEventArgs e)
//{
//    Проверяем, какой CheckBox был выбран
//    if (checkBox1.IsChecked == true)
//    {
//        Если выбран первый CheckBox, скрываем другие Canvas и отображаем первый
//        canvas2.Visibility = Visibility.Collapsed;
//        canvas3.Visibility = Visibility.Collapsed;
//        canvas1.Visibility = Visibility.Visible;
//    }
//    else if (checkBox2.IsChecked == true)
//    {
//        Если выбран второй CheckBox, скрываем другие Canvas и отображаем второй
//        canvas1.Visibility = Visibility.Collapsed;
//        canvas3.Visibility = Visibility.Collapsed;
//        canvas2.Visibility = Visibility.Visible;
//    }
//    else if (checkBox3.IsChecked == true)
//    {
//        Если выбран третий CheckBox, скрываем другие Canvas и отображаем третий
//        canvas1.Visibility = Visibility.Collapsed;
//        canvas2.Visibility = Visibility.Collapsed;
//        canvas3.Visibility = Visibility.Visible;
//    }

//    Список CheckBox
//    List<CheckBox> checkBoxes = new List<CheckBox>() { checkBox1, checkBox2, checkBox3 };
//    Выбираем случайный CheckBox
//    int randomIndex = new Random().Next(0, checkBoxes.Count);
//    CheckBox randomCheckBox = checkBoxes[randomIndex];

//    Делаем выбранный CheckBox доступным для работы
//    randomCheckBox.IsEnabled = true;

//    Отключаем остальные CheckBox
//    foreach (CheckBox checkBox in checkBoxes)
//    {
//        if (checkBox != randomCheckBox)
//        {
//            checkBox.IsEnabled = false;
//        }
//    }
//}



//private void CHB_Pet_Checked(object sender, RoutedEventArgs e)
//{
//    Random RndSel = new Random();
//    int index = RndSel.Next(0, 3);
//    if (CHB_Pet.IsEnabled == true & CHB_Dog.IsEnabled == true)
//    {
//        if (index == 0)
//        {
//            Canvas1.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 1)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//    }
//    else if (CHB_Pet.IsEnabled == true & CHB_Cat.IsEnabled == true)
//    {
//        if (index == 0)
//        {
//            Canvas1.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 2)
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas1.Visibility = Visibility.Hidden;
//        }
//    }
//    else if (CHB_Pet.IsEnabled == true & CHB_Dog.IsEnabled == true & CHB_Cat.IsEnabled == true)
//    {
//        if (index == 0)
//        {
//            Canvas1.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 1)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 2)
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas1.Visibility = Visibility.Hidden;
//        }
//    }
//}
//private void CHB_Dog_Checked(object sender, EventArgs e)
//{
//    Random RndSel = new Random();
//    int index = RndSel.Next(0, 3);
//    if (CHB_Pet.IsEnabled == true & CHB_Dog.IsEnabled == true)
//    {
//        if (index == 0)
//        {
//            Canvas1.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 1)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//    }
//    else if (CHB_Dog.IsEnabled == true & CHB_Cat.IsEnabled == true)
//    {
//        if (index == 1)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 2)
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas1.Visibility = Visibility.Hidden;
//        }
//    }
//    else if (CHB_Pet.IsEnabled == true & CHB_Dog.IsEnabled == true & CHB_Cat.IsEnabled == true)
//    {
//        if (index == 0)
//        {
//            Canvas1.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 1)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 2)
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas1.Visibility = Visibility.Hidden;
//        }
//    }
//}

//private void CHB_Cat_Checked(object sender, RoutedEventArgs e)
//{
//    Random RndSel = new Random();
//    int index = RndSel.Next(0, 3);
//    if (CHB_Pet.IsEnabled == true & CHB_Cat.IsEnabled == true)
//    {
//        if (index == 0)
//        {
//            Canvas1.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 2)
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas1.Visibility = Visibility.Hidden;
//        }
//    }
//    else if (CHB_Dog.IsEnabled == true & CHB_Cat.IsEnabled == true)
//    {
//        if (index == 1)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 2)
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas1.Visibility = Visibility.Hidden;
//        }
//    }
//    else if (CHB_Pet.IsEnabled == true & CHB_Dog.IsEnabled == true & CHB_Cat.IsEnabled == true)
//    {
//        if (index == 0)
//        {
//            Canvas1.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 1)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 2)
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas1.Visibility = Visibility.Hidden;
//        }
//    }
//}

//private void Choose_B_Click(object sender, RoutedEventArgs e)
//{
//    // Проверяем, какой CheckBox был выбран
//    if (CHB_Pet.IsChecked == true)
//    {
//        // Если выбран первый CheckBox, скрываем другие Canvas и отображаем первый
//        Canvas1.Visibility = Visibility.Visible;
//        Canvas2.Visibility = Visibility.Collapsed;
//        Canvas3.Visibility = Visibility.Collapsed;
//    }
//    else if (CHB_Dog.IsChecked == true)
//    {
//        // Если выбран второй CheckBox, скрываем другие Canvas и отображаем второй
//        Canvas2.Visibility = Visibility.Visible;
//        Canvas1.Visibility = Visibility.Collapsed;
//        Canvas3.Visibility = Visibility.Collapsed;
//    }
//    else if (CHB_Cat.IsChecked == true)
//    {
//        // Если выбран третий CheckBox, скрываем другие Canvas и отображаем третий
//        Canvas3.Visibility = Visibility.Visible;
//        Canvas2.Visibility = Visibility.Collapsed;
//        Canvas1.Visibility = Visibility.Collapsed;
//    }

//    // Список CheckBox
//    List<CheckBox> checkBoxes = new List<CheckBox>() { CHB_Pet, CHB_Dog, CHB_Cat };
//    // Выбираем случайный CheckBox
//    int randomIndex = new Random().Next(0, checkBoxes.Count);
//    CheckBox randomCheckBox = checkBoxes[randomIndex];

//    // Делаем выбранный CheckBox доступным для работы
//    randomCheckBox.IsEnabled = true;

//    // Отключаем остальные CheckBox
//    foreach (CheckBox checkBox in checkBoxes)
//    {
//        if (checkBox != randomCheckBox)
//        {
//            checkBox.IsEnabled = false;
//        }
//    }
//}


















//    private void ChooseRandomCheckBox()
//    {
//        // Выбираем случайный CheckBox из списка
//        CheckBox selectedCheckBox = checkBoxesList[randomCheck.Next(checkBoxesList.Count)];

//        // Показываем canvas, соответствующий выбранному CheckBox'у, и скрываем остальные
//        if (selectedCheckBox == CHB_Pet)
//        {
//            Canvas1.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Collapsed;
//            Canvas3.Visibility = Visibility.Collapsed;
//    }
//        else if (selectedCheckBox == CHB_Dog)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Collapsed;
//            Canvas3.Visibility = Visibility.Collapsed;
//    }
//        else if (selectedCheckBox == CHB_Cat)
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Collapsed;
//            Canvas1.Visibility = Visibility.Collapsed;
//        }
//    }
//private void CheckBox_Checked(object sender, RoutedEventArgs e)
//{
//    ChooseRandomCheckBox();
//}



















//private void CheckBox_Checked(object sender, RoutedEventArgs e)
//{
//    // Рандомно выбираем новый CheckBox
//    ChooseRandomCheckBox();
//}

//private void CHB_Pet_Checked(object sender, RoutedEventArgs e)
//{
//    ChooseRandomCheckBox();
//}

//private void CHB_Dog_Checked(object sender, RoutedEventArgs e)
//{
//    ChooseRandomCheckBox();
//}

//private void CHB_Cat_Checked(object sender, RoutedEventArgs e)
//{
//    ChooseRandomCheckBox();
//}
















//private void playButton_Click_1(object sender, RoutedEventArgs e)
//{
//    if (selectedPets.Count > 0)
//    {
//        Random RndSel = new Random();
//        int index = RndSel.Next(0, 3);
//        //int selectedPet = selectedPets[index];
//        if (index == 0)
//        {
//            Canvas1.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else if (index == 1)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas1.Visibility = Visibility.Hidden;
//        }
//    }
//    else
//    {
//        MessageBox.Show("Пожалуйста, выбери питомца");
//    }
//}






//private void CHB_Pet_Checked(object sender, RoutedEventArgs e)
//{
//    if (CHB_Pet.IsEnabled == true | CHB_Dog.IsEnabled == true)
//    {
//        selectedPets.Add(0);
//        //selectedPets.Add("Pet");
//    }
//    else
//    {
//        selectedPets.Remove(0);
//        //selectedPets.Remove("Pet");
//    }
//}
//private void CHB_Dog_Checked(object sender, EventArgs e)
//{
//    if (CHB_Dog.IsEnabled == true)
//    {
//        selectedPets.Add(1);
//    }
//    else
//    {
//        selectedPets.Remove(1);
//    }
//}

//private void CHB_Cat_Checked(object sender, RoutedEventArgs e)
//{
//    Random RndSel = new Random();
//    int index = RndSel.Next(0, 3);
//    if (CHB_Cat.IsEnabled == true | CHB_Dog.IsEnabled == true)
//    {
//        if (index == 1)
//        {
//            Canvas2.Visibility = Visibility.Visible;
//            Canvas1.Visibility = Visibility.Hidden;
//            Canvas3.Visibility = Visibility.Hidden;
//        }
//        else
//        {
//            Canvas3.Visibility = Visibility.Visible;
//            Canvas2.Visibility = Visibility.Hidden;
//            Canvas1.Visibility = Visibility.Hidden;
//        }
//        //selectedPets.Add(2);
//    }
//    else
//    {
//        selectedPets.Remove(2);
//    }
//}





//private void CheckBox_Checked(object sender, RoutedEventArgs e)
//{
//    Canvas1.Visibility = Visibility.Visible;
//    Canvas2.Visibility = Visibility.Hidden;
//    Canvas3.Visibility = Visibility.Hidden;
//}

//private void CHB_Dog_Checked(object sender, RoutedEventArgs e)
//{
//    Canvas2.Visibility = Visibility.Visible;
//    Canvas1.Visibility = Visibility.Hidden;
//    Canvas3.Visibility = Visibility.Hidden;
//}

//private void CHB_Cat_Checked(object sender, RoutedEventArgs e)
//{
//    Canvas3.Visibility = Visibility.Visible;
//    Canvas2.Visibility = Visibility.Hidden;
//    Canvas1.Visibility = Visibility.Hidden;
//}
