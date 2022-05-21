using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	// Вариант метода сброса калорий
	[Serializable]
	public class CalorieConsumptionParameter
	{
		private string _name;

		// Наименование варианта
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				Validator.Validate(value);
				_name = value;
			}
		}

		private double _calorieConsumptionRate;

		// Скорость потери калорий варианта на единицу массы
		public double CaloriConsumptionRate
		{
			get
			{
				return _calorieConsumptionRate;
			}
			set
			{
				Validator.Validate(value, 0, 100,
					"Скорость потерь калорий должна быть " +
					"от 0 до 100 ккал в час на кг.");
				_calorieConsumptionRate = value;
			}
		}

		// Конструктор
		public CalorieConsumptionParameter(string name, double value)
		{
			Name = name;
			CaloriConsumptionRate = value;
		}

		// Конструктор
		public CalorieConsumptionParameter()
		{	}
  }
}
