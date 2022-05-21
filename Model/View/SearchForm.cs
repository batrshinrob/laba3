using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
	/// <summary>
	/// Класс формы поиска
	/// </summary>
	public partial class SearchForm : Form
	{
		/// <summary>
		/// Данные для поиска
		/// </summary>
		public SearchData SearchData
		{
			get
			{
				SearchData searchData = new SearchData();
				string parameterName = "";

				try
				{
					searchData.TimeFrom = ParseString(
						_timeFrom, ref parameterName, "Время занятий от");
					searchData.TimeTo = ParseString(
						_timeTo, ref parameterName, "Время занятий до");
					searchData.MassFrom = ParseString(
						_massFrom, ref parameterName, "Масса занимающегося от");
					searchData.MassTo = ParseString(
						_massTo, ref parameterName, "Масса занимающегося до");
					searchData.CalorieFrom = ParseString(
						_calorieFrom, ref parameterName, "Расход калорий от");
					searchData.CalorieTo = ParseString(
						_calorieTo, ref parameterName, "Расход калорий до");

					if (_type.SelectedIndex < 1) searchData.Method = "";
					else searchData.Method = _type.SelectedItem.ToString();
					searchData.TextToFind = _text.Text;
				}
				catch (Exception exception)
				{
					string caption = "Ошибка при определении параметра ";
					if (parameterName != "")
						caption += parameterName;
					MessageBox.Show(exception.Message, caption);
					DialogResult = DialogResult.None;
				}

				return searchData;
			}
		}
		
		/// <summary>
		/// Чтение строки
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private float ParseString(
			TextBox textBox, ref string parameterName, string parameterNameValue)
		{
			textBox.Select();
			parameterName = parameterNameValue;
			string text = textBox.Text;
			if ((text == null) || (text == ""))
				return 0;
			else
				return float.Parse(text);
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		public SearchForm()
		{
			InitializeComponent();
		}

		private void OkClick(object sender, EventArgs e)
		{
			SearchData searchData = SearchData;
		}
	}
}
