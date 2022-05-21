using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	// Интерфейс расход калорий при занятии спортом
	public interface ICalorieConsumption
	{
		// Вес занимающегося		
		double Mass { get; set; }

		// Время занятий
		double Time { get; set; }

		// Расход калорий за занятие
		double CalorieConsumption { get; }

		// Наименование типа тренировки
		string Method { get; }

		// Описание тренировки
		string Description { get; }

		// Вариант тренировки
		int VariantIndex { get; set; }

		// Возможные варианты тренировки
		CalorieConsumptionParameter[] Variants { get; }
	}
}
