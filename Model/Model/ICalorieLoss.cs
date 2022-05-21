using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	/// <summary>
	/// Интерфейс трат калорий при занятии
	/// </summary>
	public interface ICalorieLoss
	{
		/// <summary>
		/// Масса занимающегося
		/// </summary>			
		float Mass { get; set; }

		/// <summary>
		/// Время занятий
		/// </summary>
		float Time { get; set; }

		/// <summary>
		/// Потеря калорий за занятие
		/// </summary>
		float CalorieLoss { get; }

		/// <summary>
		/// Название метода сброса калорий
		/// </summary>
		string Method { get; }

		/// <summary>
		/// Параметры метода
		/// </summary>
		string Parameters { get; }
	}
}
