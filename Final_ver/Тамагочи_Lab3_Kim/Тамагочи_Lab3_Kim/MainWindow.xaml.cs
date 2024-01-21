using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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
using Pet_Library;

namespace Тамагочи_Lab3_Kim
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

        Pet1_Lib pet = new Pet1_Lib();
        Pet1_Lib pet1 = new Pet1_Lib();//Настроение(в процентах)
        Pet1_Lib satiety1 = new Pet1_Lib();//Уровень сытости(проценты)
        Pet1_Lib forces1 = new Pet1_Lib();//Силы(проценты)
        Random r = new Random();
        int x;
        int y;
        int z;
        int a;//переменная для хранения значения x
        int b;//переменная для хранения значения y
        int c;//переменная для хранения значения z
        
        string name;
        


        public void Button_Safe_Click(object sender, RoutedEventArgs e)
        {
            Button_Caress.IsEnabled = true;
            Button_Play.IsEnabled = true;
            Button_Feed.IsEnabled = true;
            Button_Train.IsEnabled = true;

            PG_Forces.Maximum = 100;
            PG_Mood.Maximum = 100;
            PG_Satiety.Maximum = 100;

            PG_Mood.Value = pet1.Mood;
            PG_Satiety.Value = pet1.Satiety;
            PG_Forces.Value = pet1.Forces;

            pet1.Name = TB_Name.Text;
            pet1.Mood = 50;
            pet1.Satiety = 50;
            pet1.Forces = 50;
            x = int.Parse(TB_Mood.Text);
            y = int.Parse(TB_Satiety.Text);
            z = int.Parse(TB_Forces.Text);

            a = x;
            b = y;
            c = z;



            PG_Mood.Value = x;
            PG_Satiety.Value = y;
            PG_Forces.Value = z;

            Label_food.Content += " " + y;
            Label_mood.Content += " " + x;
            Label_force.Content += " " + z;

            TB_Forces.Text = null;
            TB_Mood.Text = null;
            TB_Satiety.Text = null;

            Button_Safe.IsEnabled = false;
        }


        private void Button_Caress_Click(object sender, RoutedEventArgs e)
        {
            int temp1 = Convert.ToInt32(PG_Mood.Value);
            int temp3 = Convert.ToInt32(PG_Forces.Value);

            pet1.Caress(x, z);
            PG_Mood.Value = pet1.Mood;
            PG_Forces.Value = pet1.Forces;

            TB_Forces.Text = null;
            TB_Mood.Text = null;
            TB_Satiety.Text = null;

            TB_Mood.Text = "" + (PG_Mood.Value - temp1);
            TB_Forces.Text = "" + (PG_Forces.Value - temp3);

            if (PG_Mood.Value < 0)
                TB_Mood.Text = "" + 0;
            
            if (PG_Mood.Value >100)
                TB_Mood.Text = "" + 0;

            if (PG_Forces.Value < 0)
                TB_Forces.Text = "" + 0;

            if (PG_Forces.Value > 100)
               // PG_Forces.Value = 100;
                TB_Forces.Text = "" + 0;


            //Button_Caress.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Mood,0));
            //Button_Feed.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Satiety, 0));
            //Button_Play.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Forces, 0));

        }

        private void Button_Play_Click(object sender, RoutedEventArgs e)
        {
            int temp1 = Convert.ToInt32(PG_Mood.Value);
            int temp2 = Convert.ToInt32(PG_Satiety.Value);
            int temp3 = Convert.ToInt32(PG_Forces.Value);
            

            pet1.Play(x, y, z);

            PG_Mood.Value = pet1.Mood;
            PG_Satiety.Value = pet1.Satiety;
            PG_Forces.Value = pet1.Forces;

            Button_Caress.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Satiety, 0) * Math.Max(pet1.Forces, 0));
            Button_Feed.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Satiety, 0) * Math.Max(pet1.Forces, 0));
            Button_Play.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Satiety, 0) * Math.Max(pet1.Forces, 0));
            Button_Train.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Satiety, 0) * Math.Max(pet1.Forces, 0));

            TB_Forces.Text = null;
            TB_Mood.Text = null;
            TB_Satiety.Text = null;

            TB_Mood.Text = "" + (PG_Mood.Value - temp1);
            TB_Satiety.Text = "" + (temp2 - PG_Satiety.Value);
            TB_Forces.Text = "" + (temp3 - PG_Forces.Value);

            /*if (PG_Mood.Value < 0)
                TB_Mood.Text = "" + 0;

            if (PG_Mood.Value > 100)
                TB_Mood.Text = "" + 0;

            if (PG_Satiety.Value < 0)
                TB_Satiety.Text = "" + 0;

            if (PG_Satiety.Value > 100)
                TB_Satiety.Text = "" + 0;

            if (PG_Forces.Value < 0)
                TB_Forces.Text = "" + 0;

            if (PG_Forces.Value > 100)
                //PG_Forces.Value = 100;
                TB_Forces.Text = "" + 0;*/


        }



        private void Button_Feed_Click(object sender, RoutedEventArgs e)
        {
            int temp1 = Convert.ToInt32(PG_Mood.Value);
            int temp2 = Convert.ToInt32(PG_Satiety.Value);

            pet1.Feed(x, y);

            PG_Mood.Value = pet1.Mood;
            PG_Satiety.Value = pet1.Satiety;

            TB_Forces.Text = null;
            TB_Mood.Text = null;
            TB_Satiety.Text = null;

            TB_Mood.Text = "" + (PG_Mood.Value - temp1);
            TB_Satiety.Text = "" + (PG_Satiety.Value - temp2);

           /* if (PG_Mood.Value < 0)
                TB_Mood.Text = "" + 0;

            if (PG_Mood.Value > 100)
                TB_Mood.Text = "" + 0;

            if (PG_Satiety.Value < 0)
                TB_Satiety.Text = "" + 0;

            if (PG_Satiety.Value > 100)
                TB_Satiety.Text = "" + 0;*/
        }

        private void Button_Train_Click(object sender, RoutedEventArgs e)
        {
            int temp1 = Convert.ToInt32(PG_Mood.Value);
            int temp2 = Convert.ToInt32(PG_Satiety.Value);
            int temp3 = Convert.ToInt32(PG_Forces.Value);

            pet1.Train(x, y, z);

            PG_Mood.Value = pet1.Mood;
            PG_Satiety.Value = pet1.Satiety;
            PG_Forces.Value = pet1.Forces;

            Button_Caress.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Satiety, 0) * Math.Max(pet1.Forces, 0) * Math.Max(pet1.Mood,0));
            Button_Feed.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Satiety, 0) * Math.Max(pet1.Forces, 0) * Math.Max(pet1.Mood, 0));
            Button_Play.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Satiety, 0) * Math.Max(pet1.Forces, 0) * Math.Max(pet1.Mood, 0));
            Button_Train.IsEnabled = Convert.ToBoolean(Math.Max(pet1.Satiety, 0) * Math.Max(pet1.Forces, 0) * Math.Max(pet1.Mood, 0));

            TB_Forces.Text = null;
            TB_Mood.Text = null;
            TB_Satiety.Text = null;

            TB_Mood.Text = "" + (temp1 - PG_Mood.Value);
            TB_Satiety.Text = "" + (temp2 - PG_Satiety.Value);
            TB_Forces.Text = "" + (temp3 - PG_Forces.Value);

            /*if (PG_Mood.Value < 0)
                TB_Mood.Text = "" + 0;

            if (PG_Mood.Value > 100)
                TB_Mood.Text = "" + 0;

            if (PG_Satiety.Value < 0)
                TB_Satiety.Text = "" + 0;

            if (PG_Satiety.Value > 100)
                TB_Satiety.Text = "" + 0;

            if (PG_Forces.Value < 0)
                TB_Forces.Text = "" + 0;

            if (PG_Forces.Value > 100)
                PG_Forces.Value = 100;
                TB_Forces.Text = "" + 0;*/

        }

        private void Button_Relife_Click(object sender, RoutedEventArgs e)
        {
            pet1 = new Pet1_Lib();
            Button_Safe.IsEnabled = true;
            TB_Mood.Text = Convert.ToString(a);
            TB_Satiety.Text=Convert.ToString(b);
            TB_Forces.Text=Convert.ToString(c);
            //a=x;
            //b=y;
            //c=z;
            int temp1 = Convert.ToInt32(PG_Mood.Value);
            int temp2 = Convert.ToInt32(PG_Satiety.Value);
            int temp3 = Convert.ToInt32(PG_Forces.Value);
            
            Label_food.Content = "Введите параметр \nсытости";
            Label_mood.Content = "Введите параметр \nнастроения";
            Label_force.Content = "Введите параметр \nсилы";

            //a=temp1;
            //b= temp2;
            //c= temp3;


            //if (Button_Safe.IsEnabled = true)
            //{ 
            //    temp1 = a;
            //    temp2 = b;
            //    temp3 = c;
            //}


            /*PG_Mood.Value = x;
            PG_Satiety.Value = y;
            PG_Forces.Value = z;*/

            

            /*TB_Mood.Text = null;
            TB_Satiety.Text = null;
            TB_Forces.Text = null;*/
            
        }
    }

}
