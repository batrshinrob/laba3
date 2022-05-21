using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Model;

namespace View
{
	/// <summary>
	/// Класс основной формы (таблицы тренировок)
	/// </summary>
	public partial class CalorieLossComputeForm : Form
	{
		/// <summary>
		/// Конструктор
		/// </summary>
		public CalorieLossComputeForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Кнопка Add
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddClick(object sender, EventArgs e)
		{
			AddTrainForm add = new AddTrainForm();
			if (add.ShowDialog() == DialogResult.OK)
			{
				AddTraining(add.Training);
			}
		}

		/// <summary>
		/// Добавить тренировку
		/// </summary>
		/// <param name="training"></param>
		void AddTraining(ICalorieLoss training)
		{
			string[] data =
			{
				training.Method,
				training.Mass.ToString(),
				training.Time.ToString(),
				training.Parameters,
				training.CalorieLoss.ToString()
			};
			_trains.Rows.Add(data);
			_trainings.Items.Add(training);
			_trainings.SelectedIndex = _trainings.Items.Count - 1;
		}

		/// <summary>
		/// Кнопка Remove
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveClick(object sender, EventArgs e)
		{
			_selecting = true;
			for (int i = _trainings.SelectedIndices.Count - 1; i >= 0; i--)
			{
				_trains.Rows.RemoveAt(_trainings.SelectedIndices[i]);
				_trainings.Items.RemoveAt(_trainings.SelectedIndices[i]);
			}
			_selecting = false;
		}

		private bool _selecting = false;

		/// <summary>
		/// Изменился выбор в ListBox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TrainingsSelectedIndexChanged(object sender, EventArgs e)
		{
			if (_selecting) return;
			_selecting = true;
			for (int i = 0; i < _trains.RowCount; i++)
				_trains.Rows[i].Selected = false;
			for (int i = 0; i < _trainings.SelectedIndices.Count; i++)
				_trains.Rows[_trainings.SelectedIndices[i]].Selected = true;
			_selecting = false;
		}

		/// <summary>
		/// Изменился выбор в таблице
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TrainsSelectionChanged(object sender, EventArgs e)
		{
			if (_selecting) return;
			_selecting = true;
			_trainings.ClearSelected();
			for (int i = 0; i < _trains.SelectedRows.Count; i++)
			{
				int index = _trains.SelectedRows[i].Index;
				if (index < _trainings.Items.Count)
					_trainings.SetSelected(index, true);
			}
			_selecting = false;
		}

		/// <summary>
		/// Кнопка Search
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SearchClick(object sender, EventArgs e)
		{
			SearchForm search = new SearchForm();
			if (search.ShowDialog() == DialogResult.OK)
			{
				_trainings.ClearSelected();
				try
				{
					SearchData searchData = search.SearchData;

					for (int i = 0; i < _trainings.Items.Count; i++)
					{
						ICalorieLoss calorieLoss = (ICalorieLoss)_trainings.Items[i];
						if ((searchData.MassFrom != 0) && 
							(calorieLoss.Mass < searchData.MassFrom))
							continue;
						if ((searchData.MassTo != 0) && 
							(calorieLoss.Mass > searchData.MassTo))
							continue;
						if ((searchData.TimeFrom != 0) && 
							(calorieLoss.Time < searchData.TimeFrom))
							continue;
						if ((searchData.TimeTo != 0) && 
							(calorieLoss.Time > searchData.TimeTo))
							continue;
						if ((searchData.CalorieFrom != 0) && 
							(calorieLoss.CalorieLoss < searchData.CalorieFrom))
							continue;
						if ((searchData.CalorieTo != 0) && 
							(calorieLoss.CalorieLoss > searchData.CalorieTo))
							continue;
						if ((searchData.Method != "") && 
							(searchData.Method.ToLower() != calorieLoss.Method.ToLower()))
							continue;
						if ((searchData.TextToFind != "") &&
							(calorieLoss.Parameters.ToLower().IndexOf(
								searchData.TextToFind.ToLower()) == -1))
							continue;

						_trains.Rows[i].Selected = true;
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message + 
						"\r\nПовторите поиск с корректными параметрами.", 
						"Ошибка выполнения поиска");
				}
			}
		}

		/// <summary>
		/// Кнопка Save
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveClick(object sender, EventArgs e)
		{
			if (_saveDialog.ShowDialog() == DialogResult.OK)
			{
				BinaryFormatter formatter = new BinaryFormatter();
				using (Stream fileStream = new FileStream(_saveDialog.FileName,
					FileMode.Create, FileAccess.Write, FileShare.None))
				{
					for (int i = 0; i < _trainings.Items.Count; i++)
						formatter.Serialize(fileStream, _trainings.Items[i]);
				}
			}
		}

		/// <summary>
		/// Кнопка Load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoadClick(object sender, EventArgs e)
		{
			if (_trainings.Items.Count != 0)
			{
				DialogResult desigion = MessageBox.Show(
					"Очистить данные перед загрузкой?",
					"Запрос",
					MessageBoxButtons.YesNoCancel);
				if (desigion == DialogResult.Cancel) return;
				if (desigion == DialogResult.Yes)
				{
					desigion = MessageBox.Show(
					"Сохранить введенные данные перед очисткой?",
					"Запрос",
					MessageBoxButtons.YesNoCancel);
					if (desigion == DialogResult.Cancel) return;
					if (desigion == DialogResult.Yes) SaveClick(null, e);

					_trainings.Items.Clear();
					_trains.Rows.Clear();

				}
			}

			if (_openDialog.ShowDialog() == DialogResult.OK)
			{
				BinaryFormatter formatter = new BinaryFormatter();
				using (Stream fileStream = new FileStream(_openDialog.FileName,
					FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					while (fileStream.Position < (fileStream.Length - 1))
					{
						try
						{
							object readObject = formatter.Deserialize(fileStream);
							if (readObject is ICalorieLoss)
								AddTraining((ICalorieLoss)readObject);
						}
						catch (Exception exception)
						{
							MessageBox.Show(
								"Ошибка чтения файла:\r\n" + exception.Message);
							return;
						}
					}
				}
			}

		}
	}
}
