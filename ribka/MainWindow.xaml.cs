using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace ribka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

        
    {
        logic logic = new logic();
        classi classi = new classi();
        System.Windows.Threading.DispatcherTimer Timer;
      
        
        public MainWindow()
        {
            InitializeComponent();
            sexa.Maximum = 100;
            precent_havchika.Maximum = 70;
            precent_havchika.Minimum = 1;
            ribonki.Maximum = 100;
            ribonki.Minimum = 1;
        }
        classi.Cells[,] pole = new classi.Cells[30, 50];
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    
                   pole[i,j] = new classi.Cells(false, false);

                }
            }
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 50; j++)
                {

                    pole[i, j].isplace = logic.setplant(i,j, Convert.ToInt32(precent_havchika.Value));


                }
            }

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    grida.Content += logic.hz(pole[i, j].isfood);
                }
                grida.Content += "\n";
            }
            


            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 0, 0, 250);
            Timer.Start();


        }
        int ticker = 0;





        // тут наш аквариум живет
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            ticker++;
            tickspass.Content = ticker;
            // создать лист из рыб и чекать их координаты
        }


        //============================
            private void Sexa_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            male_percent.Content = Convert.ToInt32(sexa.Value) + "% male";
            female_percent.Content = 100 - Convert.ToInt32(sexa.Value) + "% female" ;
        }

       

       

        

        private void precent_havchika_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label_onhavchik.Content = Convert.ToInt32(precent_havchika.Value) + "%";
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            grida.Content = "";
            ticker = 0;
            Timer.Stop();
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 50; j++)
                {

                    pole[i, j] = new classi.Cells(false, false);

                }
            }
        }

        private void ribonki_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label_ribonki.Content = Convert.ToInt32(ribonki.Value);
        }
    }


    

}
