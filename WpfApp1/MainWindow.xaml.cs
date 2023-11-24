using Lib7;
using System.Windows;

namespace практическая__7
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

		private void Сложить(object sender, RoutedEventArgs e)
		{
			if (!int.TryParse(Рубли1Пары.Text, out int a)
			|| !int.TryParse(Копейки1Пары.Text, out int b)
			|| !int.TryParse(Рубли2Пары.Text, out int c)
			|| !int.TryParse(Копейки2Пары.Text, out int d))
			{
				MessageBox.Show("Введите правильно");
				return;
			}

			Money pair1 = new Money(a, b);
			Money pair2 = new Money(c, d);
			Money pair3 = pair1 + pair2;
			Рубли3Пары.Text = pair3.Roubles.ToString();
			Копейки3Пары.Text = pair3.Pennies.ToString();
		}

		private void ОПрограмме(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Автор: Гришина Наталия\nПрактическая работа №7\nЗадание: Использовать класс  Pair  (пара  чисел).\nОпределить  класс-наследник Money с характеристиками: рубли и копейки.\nПереопределить операцию сложения и определить методы вычитания и деления денежных сумм.");
		}

		private void Выход(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void Очистить(object sender, RoutedEventArgs e)
		{
			Рубли1Пары.Clear();
			Копейки1Пары.Clear();
			Рубли2Пары.Clear();
			Копейки2Пары.Clear();
			Рубли3Пары.Clear();
			Копейки3Пары.Clear();
            ПользовательскийДелитель.Clear();
        }

		private void Вычесть(object sender, RoutedEventArgs e)
		{
			if (!int.TryParse(Рубли1Пары.Text, out int a)
			|| !int.TryParse(Копейки1Пары.Text, out int b)
			|| !int.TryParse(Рубли2Пары.Text, out int c)
			|| !int.TryParse(Копейки2Пары.Text, out int d))
			{
				MessageBox.Show("Введите правильно");
				return;
			}

			Money pair1 = new Money(a, b);
			Money pair2 = new Money(c, d);
			Money pair3 = pair1.Difference(pair2);
			Рубли3Пары.Text = pair3.Roubles.ToString();
			if (pair3.Roubles < 0) Рубли3Пары.Text += " (На Вас кредит)";

			Копейки3Пары.Text = pair3.Pennies.ToString();
			if (pair3.Pennies < 0) Копейки3Пары.Text += " (На Вас кредит)";
		}

		private void Делить(object sender, RoutedEventArgs e)
		{
			if (!int.TryParse(Рубли1Пары.Text, out int a)
			|| !int.TryParse(Копейки1Пары.Text, out int b)
			|| !int.TryParse(ПользовательскийДелитель.Text, out int d))
			{
				MessageBox.Show("Введите правильно");
				return;
			}

			Money pair1 = new Money(a, b);

			pair1 = pair1.Division(d);

			Рубли1Пары.Text = pair1.Roubles.ToString();
			Копейки1Пары.Text = pair1.Pennies.ToString();
		}
	}
}

