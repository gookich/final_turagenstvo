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

namespace livenlup1
{
    /// <summary>
    /// Логика взаимодействия для CommentPage.xaml
    /// </summary>
    public partial class CommentPage : Page
    {
        private hotel _currentComment = new hotel();
        public CommentPage(hotel selectedHotel)
        {
            InitializeComponent();
            DataContext = _currentComment;
            //ComboHotel.ItemsSource = ToursBaseEntities.GetContext().hotels.ToList();
        }

        private void ButtonSend_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Комментарий сохранен");
        }
    }
}
