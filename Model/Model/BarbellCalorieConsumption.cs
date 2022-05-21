using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	// Жим штанги
	[Serializable]
	public class BarbellCalorieConsumption : ICalorieConsumption
	{
		private double _mass = -1;

		// Вес занимающегося		
		public double Mass
		{
			get
			{
				return _mass;
			}
			set
			{
                //Проверяем находится ли масса в допустимых пределах
                Validator.Validate(value, 10, 500, 
					"Введите корректное значение веса занимающегося (от 10 до 500 кг).");
				_mass = value;
			}
		}

		private double _time = -1;

		// Время занятий
		public double Time
		{
			get
			{
				return _time;
			}
			set
			{
                //Проверяем находится ли время занятия в допустимых пределах
                Validator.Validate(value, 1, 600,
					"Введите корректное значение времени занятий (от 1 до 600 мин.).");
				_time = value;
			}
		}

		// Расход калорий за занятие
		public double CalorieConsumption
		{
			get
			{
                //Возвращаем затрат калорий
                return _time * _mass * 7 / 60;
			}
		}

		// Наименование типа тренировки
		public string Method
		{
			get
			{
				return "Жим штанги";
			}
		}

		// Описание тренировки
		public string Description
		{
			get
			{
				return $"{Method} {_time} мин.";
			}
		}

		// Описание объекта
		public override string ToString()
		{
			return Description;
		}

		// Вариант для данной тренировки
		public int VariantIndex
		{
			get
			{
				return -1;
			}
			set
			{
				if (value != -1)
					throw new Exception("Выбор варианта тренировки не реализован.");
			}
		}

		// Возможные варианты тренировки
		public CalorieConsumptionParameter[] Variants
		{
			get
			{
				return new CalorieConsumptionParameter[]{ };
			}
		}
	}
}
