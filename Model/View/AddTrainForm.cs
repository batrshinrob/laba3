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
	/// <summary>
	/// Форма ввода данных тренировки
	/// </summary>
	public partial class AddTrainForm : Form
	{
		/// <summary>
		/// Интерфейс потери энергии за тренировку
		/// </summary>
		private ICalorieLoss _trainingCalorieLoss;

		/// <summary>
		/// Введенная тренировка
		/// </summary>
		public ICalorieLoss Training
		{
			get
			{
				return _trainingCalorieLoss;
			}
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		public AddTrainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Изменился выбор типа тренировки
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TrainingTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			switch (_trainingType.SelectedIndex)
			{
				case -1:
					_particularParameters.Visible = false;
					break;

				case 0:
					_parameter1Name.Text = "Скорость бега (км/ч):";
					_parameter2Name.Text = "Дистанция (м):";
					_parameterSwitch.Visible = false;
					_parameterSwitchName.Visible = false;
					break;

				case 1:
					_parameter1Name.Text = "Скорость плавания (м/мин):";
					_parameter2Name.Text = "Дистанция (м):";
					_parameterSwitch.Visible = true;
					_parameterSwitchName.Visible = true;
					break;

				case 2:
					_parameter2Name.Text = "Вес штанги (кг):";
					_parameter1Name.Text = "Количество жимов:";
					_parameterSwitch.Visible = false;
					_parameterSwitchName.Visible = false;
					break;
			}

			_particularParameters.Visible = (_trainingType.SelectedIndex >= 0);
			_parameter1Name.Visible = _particularParameters.Visible;
			_parameter1Value.Visible = _particularParameters.Visible;
		}

		/// <summary>
		/// Кнопка OK
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OKClick(object sender, EventArgs e)
		{
			ICalorieLoss training = null;
			string parameterName = "";
			try
			{
				switch (_trainingType.SelectedIndex)
				{
					case 0:
						RunCalorieLoss run = new RunCalorieLoss();
						_parameter1Value.Select();
						parameterName = "Скорость";
						run.Velocity = float.Parse(_parameter1Value.Text);
						_parameter2Value.Select();
						parameterName = "Дистанция";
						float distance = float.Parse(_parameter2Value.Text);
						Validator.ValidateLite(distance, 5, 
							"Дистанция должна быть не менее 5 м и быть конечной.");
						run.Time = distance / run.Velocity * 60 / 1000;
						_massValue.Select();
						parameterName = "Масса тренирующегося";
						run.Mass = float.Parse(_massValue.Text);
						training = run;
						break;

					case 1:
						SwimCalorieLoss swim = new SwimCalorieLoss();
						_parameter1Value.Select();
						parameterName = "Скорость плавания";
						float velocity = float.Parse(_parameter1Value.Text);
						Validator.Validate(velocity, 0,
							"Скорость плавания должна быть больше нуля.");

						if (velocity < 46F)
							swim.IntensityIndex = 0;
						else if (velocity < 70F)
							swim.IntensityIndex = 1;
						else
							swim.IntensityIndex = 2;

						_parameter2Value.Select();
						parameterName = "Дистанция";
						distance = float.Parse(_parameter2Value.Text);
						Validator.ValidateLite(distance, 1,
							"Дистанция должна быть не менее 1 м.");
						swim.Time = distance / velocity;
						_massValue.Select();
						parameterName = "Масса тренирующегося";
						swim.Mass = float.Parse(_massValue.Text);
						_parameterSwitch.Select();
						int styleIndex = _parameterSwitch.SelectedIndex;
						if (styleIndex == -1)
						{
							MessageBox.Show("Не выбран стиль плавания.\r\n" +
								"Необходимо выбрать стиль плавания.",
								"Ошибка при определении параметра Стиль плавания");
							DialogResult = DialogResult.None;
							return;
						}
						swim.StyleIndex = styleIndex;
						training = swim;
						break;

					case 2:
						BarbellCalorieLoss barbell = new BarbellCalorieLoss();
						_massValue.Select();
						parameterName = "Масса тренирующегося";
						barbell.Mass = float.Parse(_massValue.Text);
						_parameter2Value.Select();
						parameterName = "Вес штанги";
						barbell.Weight = float.Parse(_parameter2Value.Text);
						_parameter1Value.Select();
						parameterName = "Количество жимов";
						barbell.Count = int.Parse(_parameter1Value.Text);
						barbell.Time = 2F * barbell.Count / 60;
						training = barbell;
						break;
				}
			}
			catch (Exception exception)
			{
				string caption = "Ошибка при определении параметра ";
				if (parameterName != "")
					caption += parameterName;
				MessageBox.Show(exception.Message + 
					"\r\nВведите корректное положительное число для данного параметра.", 
					caption);
				DialogResult = DialogResult.None;
				return;
			}

			_trainingCalorieLoss = training;
			if (training == null)
			{
				DialogResult = DialogResult.None;
				MessageBox.Show(
					"Не выбран тип тренировки. \r\n" +
					"Выберите тип тренировки и введите ее параметры.",
					"Ошибка при определении параметра Тип тренировки");
			}
		}

#if (DEBUG)
		/// <summary>
		/// Кнопка Random
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomClick(object sender, EventArgs e)
		{
			Random random = new Random();
			_trainingType.SelectedIndex = random.Next(3);
			int mass = random.Next(100) + 10;
			_massValue.Text = mass.ToString();
			int value = random.Next(20) + 6;
			_parameter1Value.Text = value.ToString();
			value = random.Next(10) * 1000;
			if (value == 0) value = random.Next(1000) + 30;
			if (_trainingType.SelectedIndex == 2)
				value = random.Next(20) * 10 + 10;
			_parameter2Value.Text = value.ToString();
			_parameterSwitch.SelectedIndex = random.Next(10);
		}
#endif
	}
}
