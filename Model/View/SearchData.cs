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
	/// Структура для поиска данных по потере калорий за тренировку
	/// </summary>
	public struct SearchData
	{
		private float _calorieFrom;
		private float _calorieTo;
		private float _massFrom;
		private float _massTo;
		private float _timeFrom;
		private float _timeTo;
		private string _textToFind;
		private string _method;

		/// <summary>
		/// Нижний предел потери калорий
		/// </summary>
		public float CalorieFrom
		{
			get
			{
				return _calorieFrom;
			}
			set
			{
				Validator.ValidateLite(
					value,
					0,
					"Нижний предел потери калорий при поиске должен быть" +
					" положительным числом.");
				_calorieFrom = value;
			}
		}

		/// <summary>
		/// Верхний предел потери калорий
		/// </summary>
		public float CalorieTo
		{
			get
			{
				return _calorieTo;
			}
			set
			{
				Validator.ValidateLite(
					value,
					0,
					"Верхний предел потери калорий при поиске должен быть" +
					" положительным числом.");
				_calorieTo = value;
			}
		}

		/// <summary>
		/// Нижний предел массы
		/// </summary>
		public float MassFrom
		{
			get
			{
				return _massFrom;
			}
			set
			{
				Validator.ValidateLite(
					value,
					0,
					"Нижний предел массы при поиске должен быть" +
					" положительным числом.");
				_massFrom = value;
			}
		}

		/// <summary>
		/// Верхний предел массы
		/// </summary>
		public float MassTo
		{
			get
			{
				return _massTo;
			}
			set
			{
				Validator.ValidateLite(
					value,
					0,
					"Верхний предел массы при поиске должен быть" +
					"положительным числом.");
				_massTo = value;
			}
		}

		/// <summary>
		/// Нижний предел времени тренировки
		/// </summary>
		public float TimeFrom
		{
			get
			{
				return _timeFrom;
			}
			set
			{
				Validator.ValidateLite(
					value,
					0,
					"Верхний предел времени тренировки при поиске должен быть" +
					"положительным числом.");
				_timeFrom = value;
			}
		}

		/// <summary>
		/// Верхний предел времени тренировки
		/// </summary>
		public float TimeTo
		{
			get
			{
				return _timeTo;
			}
			set
			{
				Validator.ValidateLite(
					value,
					0,
					"Нижний предел времени тренировки при поиске должен быть" +
					"положительным числом.");
				_timeTo = value;
			}
		}

		/// <summary>
		/// Текст для поиска
		/// </summary>
		public string TextToFind
		{
			get
			{
				return _textToFind;
			}
			set
			{
				Validator.ValidateString(value);
				_textToFind = value;
			}
		}

		/// <summary>
		/// Вид тренировки
		/// </summary>
		public string Method
		{
			get
			{
				return _method;
			}
			set
			{
				Validator.ValidateString(value);
				if (value != "")
					Validator.ValidateMethod(value);
				_method = value;
			}
		}
	}
}