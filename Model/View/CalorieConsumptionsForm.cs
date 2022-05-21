using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

using Model;

namespace View
{
	public partial class CalorieConsumptionsForm : Form
	{
		private bool _selectionChanging = false;

		public CalorieConsumptionsForm()
		{
			InitializeComponent();
		}

		// Кнопка Выход
		private void ExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void AddClick(object sender, EventArgs e)
		{
			AddCalorieConsumptionForm addForm = new AddCalorieConsumptionForm();
			if (addForm.ShowDialog() == DialogResult.OK)
			{
				_calorieConsumptionsList.Items.Add(addForm.CalorieConsumption);
				int activityVariantIndex = addForm.CalorieConsumption.VariantIndex;
				string activityVariant = "";
				if (activityVariantIndex != -1)
					activityVariant =
						addForm.CalorieConsumption.Variants[activityVariantIndex].Name;
				_calorieConsumptionsTable.Rows.Add(new string[5]
				{
					addForm.CalorieConsumption.Method,
					activityVariant,
					addForm.CalorieConsumption.Mass.ToString(),
					addForm.CalorieConsumption.Time.ToString(),
					addForm.CalorieConsumption.CalorieConsumption.ToString()
				}
				);
			}
		}

		// Изменение выбора в списке активностей
		private void CalorieConsumptionsListSelectedIndexChanged(
			object sender, EventArgs e)
		{
			if (_selectionChanging) return;
			_selectionChanging = true;

			try
			{
				for (int i = 0; i < _calorieConsumptionsList.Items.Count; i++)
				{
					if (_calorieConsumptionsList.SelectedItems.IndexOf(
						_calorieConsumptionsList.Items[i]) == -1)
						_calorieConsumptionsTable.Rows[i].Selected = false;
					else
						_calorieConsumptionsTable.Rows[i].Selected = true;
				}
			}
			finally
			{
				_selectionChanging = false;
			}
		}

		// Изменение в выборе элементов таблицы активностей
		private void CalorieConsumptionsTableSelectionChanged(
			object sender, EventArgs e)
		{
			if (_selectionChanging) return;
			_selectionChanging = true;

			try
			{
				_calorieConsumptionsList.ClearSelected();
				for (int i = 0; i < _calorieConsumptionsTable.RowCount; i++)
				{
					for (int j = 0; j < _calorieConsumptionsTable.ColumnCount; j++)
						if (_calorieConsumptionsTable.Rows[i].Cells[j].Selected)
						{
							_calorieConsumptionsList.SelectedItems.Add(
								_calorieConsumptionsList.Items[i]);
							break;
						}
				}
			}
			finally
			{
				_selectionChanging = false;
			}

		}

		// Удаление
		private void RemoveClick(object sender, EventArgs e)
		{
			_selectionChanging = true;
			try
			{
				for (int i = _calorieConsumptionsList.Items.Count - 1; i >= 0; i--)
				{
					object item = _calorieConsumptionsList.Items[i];
					if (_calorieConsumptionsList.SelectedItems.IndexOf(item) != -1)
					{
						_calorieConsumptionsList.Items.RemoveAt(i);
						_calorieConsumptionsTable.Rows.RemoveAt(i);
					}
				}

				for (int i = 0; i < _calorieConsumptionsTable.RowCount; i++)
					for (int j = 0; j < _calorieConsumptionsTable.ColumnCount; j++)
						_calorieConsumptionsTable.Rows[i].Cells[j].Selected = false;
			}
			finally
			{
				_selectionChanging = false;
			}
		}

		// Кнопка Поиск
		private void FindClick(object sender, EventArgs e)
		{
			FindForm findForm = new FindForm();
			if (findForm.ShowDialog() == DialogResult.OK)
			{
				_calorieConsumptionsList.SelectedIndices.Clear();
				string[] strings = findForm.FindData.Strings;
				double[] values = findForm.FindData.Values;

				for (int i = 0; i < _calorieConsumptionsTable.RowCount; i++)
				{
					bool ok = true;
					for (int j = 0;
						(j < _calorieConsumptionsTable.ColumnCount) &&
						(j < strings.Length);
						j++)
					{
						if (strings[j] == "") continue;

						string cellText =
							_calorieConsumptionsTable.Rows[i].Cells[j].Value.ToString();

						ok = (cellText == strings[j]);
						if (!ok) break;
					}

					if (!ok) continue;

					double tollerance = values[0] / 100;
					if (tollerance == 0) tollerance = 0.001;

					for (int j = 1;
						(j < _calorieConsumptionsTable.ColumnCount - 1) &&
						(j < values.Length);
						j++)
					{
						if (values[j] == 0) continue;
						string tableValueString = _calorieConsumptionsTable.Rows[i].
							Cells[j + 1].Value.ToString();
						double tableValue = double.Parse(tableValueString);
						double absoluteTollerance = tollerance * tableValue;
						if (absoluteTollerance == 0)
						{
							absoluteTollerance = 0.1;
							int fractionalDigitCount = tableValueString.IndexOf(',');
							if (fractionalDigitCount == -1)
								fractionalDigitCount = tableValueString.IndexOf('.');
							if (fractionalDigitCount != -1)
							{
								for (int k = 0; k <= fractionalDigitCount; k++)
									absoluteTollerance *= 0.1;
							}
						}
						double minValue = tableValue - absoluteTollerance;
						double maxValue = tableValue + absoluteTollerance;
						ok = (values[j] >= minValue &&
								(values[j] <= maxValue));
						if (!ok) break;

					}

					_calorieConsumptionsTable.Rows[i].Selected = ok;
				}
			}
		}

		// Кнопка Сохранить
		private void SaveClick(object sender, EventArgs e)
		{
			if (_saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				int activityCount = _calorieConsumptionsList.Items.Count;
				ICalorieConsumption[] calorieConsumptions =
					new ICalorieConsumption[activityCount];
				for (int i = 0; i < _calorieConsumptionsList.Items.Count; i++)
				{
					calorieConsumptions[i] =
						(ICalorieConsumption)_calorieConsumptionsList.Items[i];
				}

				var writer = new BinaryFormatter();
				using (var file = System.IO.File.Create(_saveFileDialog.FileName))
				{
					writer.Serialize(file, calorieConsumptions);
					file.Close();
				}
			}
		}

		// Кнопка Загрузить 
		private void LoadClick(object sender, EventArgs e)
		{
			if (_openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					var reader = new BinaryFormatter();
					using (var file = System.IO.File.OpenRead(_openFileDialog.FileName))
					{
						ICalorieConsumption[] calorieConsumptions =
							(ICalorieConsumption[])reader.Deserialize(file);
						file.Close();

						_calorieConsumptionsList.Items.Clear();
						_calorieConsumptionsTable.Rows.Clear();

						for (int i = 0; i < calorieConsumptions.Count(); i++)
						{
							_calorieConsumptionsList.Items.Add(calorieConsumptions[i]);
							int activityVariantIndex = calorieConsumptions[i].VariantIndex;
							string activityVariant = "";
							if (activityVariantIndex != -1)
								activityVariant =
									calorieConsumptions[i].Variants[activityVariantIndex].Name;
							_calorieConsumptionsTable.Rows.Add(new string[5]
							{
								calorieConsumptions[i].Method,
								activityVariant,
								calorieConsumptions[i].Mass.ToString(),
								calorieConsumptions[i].Time.ToString(),
								calorieConsumptions[i].CalorieConsumption.ToString()
							}
							);
						}
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, "Ошибка десериализации");
				}
			}
		}
	}
}

