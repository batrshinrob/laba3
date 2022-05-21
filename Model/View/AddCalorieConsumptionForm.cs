using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;

namespace View
{
	// Форма добавления затрат калорий
	public partial class AddCalorieConsumptionForm : Form
	{
		// Конструктор
		public AddCalorieConsumptionForm()
		{
			InitializeComponent();
		}

		// Результат работы формы - затраты калорий
		private ICalorieConsumption _calorieConsumption = null;
		public ICalorieConsumption CalorieConsumption
		{
			get
			{
				return _calorieConsumption;
			}
		}

		// Выбор активности
		private void ActivitySelectorSelectedIndexChanged(
			object sender, EventArgs e)
		{
			_activityVariantSelector.Items.Clear();
			if ((_activitySelector.SelectedIndex == -1) ||
				(_activitySelector.SelectedIndex == 1))
				_activityVariantSelector.Enabled = false;
			else
			{
				_activityVariantSelector.Enabled = true;
				if (_activitySelector.SelectedIndex == 0)
					_activityVariantSelector.Items.AddRange(
						GetVariants(new RunCalorieConsumption()));
				else
					_activityVariantSelector.Items.AddRange(
						GetVariants(new SwimCalorieConsumption()));
			}
		}

		// Варианты данной активности
		private string[] GetVariants(ICalorieConsumption consumption)
		{
			int variantCount = consumption.Variants.Count();
			string[] variants = new string[variantCount];
			for (int i = 0; i < variantCount; i++)
				variants[i] = consumption.Variants[i].Name;
			return variants;
		}

		// Кнопка ОК
		private void OKClick(object sender, EventArgs e)
		{
			int activityVariantIndex = _activityVariantSelector.SelectedIndex;
			try
			{
				switch (_activitySelector.SelectedIndex)
				{
					case 0:
						_calorieConsumption = new RunCalorieConsumption();
						_calorieConsumption.VariantIndex = activityVariantIndex;
						break;
					case 1:
						_calorieConsumption = new BarbellCalorieConsumption();
						break;
					case 2:
						_calorieConsumption = new SwimCalorieConsumption();
						_calorieConsumption.VariantIndex = activityVariantIndex;
						break;
					default:
						MessageBox.Show("Необходимо выбрать вид активности.", "Ошибка");
						return;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(
					exception.Message, "Ошибка параметра \"Вариант активности\"");
				return;
			}

			try
			{
				_calorieConsumption.Mass = double.Parse(_massInput.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(
					exception.Message, "Ошибка параметра \"Масса человека\"");
				return;
			}

			try
			{
				_calorieConsumption.Time = double.Parse(_timeInput.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(
					exception.Message, "Ошибка параметра \"Длительность активности\"");
				return;
			}

			DialogResult = DialogResult.OK;
		}

#if (DEBUG)
		// Кнопка Случайные данные
		private void RandomClick(object sender, EventArgs e)
		{
			SetRandomValue(_activitySelector);
			SetRandomValue(_activityVariantSelector);
			SetRandomValue(_timeInput, 1, 120);
			SetRandomValue(_massInput, 10, 100);
		}

		// Установка случайного значения в ComboBox
		void SetRandomValue(ComboBox comboBox)
		{
			int count = comboBox.Items.Count;
			if (count == 0) return;
			Random random = new Random();
			comboBox.SelectedIndex = random.Next(count);
		}

		// Установка случайного числа в TextBox
		void SetRandomValue(TextBox textBox, int minValue, int maxValue)
		{
			Random random = new Random();
			textBox.Text = random.Next(minValue, maxValue).ToString();
    }
#endif
	}
}
