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

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void NumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			numberTextBlock.Text = numberTextBox.Text;
		}

		private void NumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !int.TryParse(e.Text, out _);
		}

		private void SmallSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			numberTextBlock.Text = smallSlider.Value.ToString("0");
		}

		private void BigSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			numberTextBlock.Text = bigSlider.Value.ToString("000-000-0000");
		}

		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			if (sender is RadioButton radioButton){
				numberTextBlock.Text = radioButton.Content.ToString();
			}
		}

		private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (myListBox.SelectedItem is ListBoxItem listBoxItem){
				numberTextBlock.Text = listBoxItem.Content.ToString();
			}
		}

		private void ReadOnlyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (readOnlyComboBox.SelectedItem is ListBoxItem listBoxItem){
				numberTextBlock.Text = listBoxItem.Content.ToString();
			}
		}

		private void EditableComboBox_TextChanged(object sender, RoutedEventArgs e)
		{
			if (sender is ComboBox comboBox){
				numberTextBlock.Text = comboBox.Text;
			}
		}
	}
}
