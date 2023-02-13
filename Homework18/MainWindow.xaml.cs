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
using FactoryLogic;

namespace Homework18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository repository;
        public MainWindow()
        {
            repository = new Repository();
            InitializeComponent();

            repository.Load();
            Animals.ItemsSource = repository.animals;
        }

        private void EnterBut_Click(object sender, RoutedEventArgs e)
        {
            if (Animals.SelectedItem != null)
            {
                repository.Change(Animals.SelectedIndex, Species.Text);
            }
            else
            {
                repository.Add(Factory.NewAnimal(Class.Text, Species.Text));
            }
            Animals.Items.Refresh();
        }

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            repository.Remove(Animals.SelectedIndex);
            Animals.Items.Refresh();
        }

        private void SaveBut_Click(object sender, RoutedEventArgs e)
        {
            repository.Save();
            MessageBox.Show("Данные сохранены.", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
