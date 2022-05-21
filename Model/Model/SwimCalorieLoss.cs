using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	// Плавание
	[Serializable]
	public class SwimCalorieConsumption : ICalorieConsumption
	{
		// Возможные виды плавания
		private CalorieConsumptionParameter[] _variants =
			new CalorieConsumptionParameter[5]
		{
			new CalorieConsumptionParameter("Плавание (0,4 км/ч)",  3 ),
			new CalorieConsumptionParameter("Медленное плавание брассом", 6),
			new CalorieConsumptionParameter("Плавание (2,4 км/ч)", 7),
			new CalorieConsumptionParameter("Медленное плавание кролем",  7),
			new CalorieConsumptionParameter("Плавание быстрым кролем", 8)
		};

		// Возможные виды плавания
		public CalorieConsumptionParameter[] Variants
		{
			get
			{
				return _variants;
			}
		}

		private int _variantIndex = -1;

		// Вариант плавания для данной тренировки
		public int VariantIndex
		{
			get
			{
				return _variantIndex;
			}
			set
			{
				if ((value < 0) || (value > Variants.Length))
					throw new Exception(
						"Выберете индекс варианта тренировки в пределах от 0 до " +
						(Variants.Length - 1).ToString() + ".");
				_variantIndex = value;
			}
		}

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
				return _time * _mass / 60 *
					Variants[_variantIndex].CaloriConsumptionRate;
			}
		}

		// Наименование типа тренировки
		public string Method
		{
			get
			{
				return "Плавание";
			}
		}

		// Описание тренировки
		public string Description
		{
			get
			{
				return $"{Variants[_variantIndex].Name} {_time} мин.";
			}
		}

		// Описание объекта
		public override string ToString()
		{
			return Description;
		}
	}
}