using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
	// Бег
	[Serializable]
	public class RunCalorieConsumption : ICalorieConsumption
	{
		// Возможные виды бега
		private CalorieConsumptionParameter[] _variants =
			new CalorieConsumptionParameter[5]
		{
			new CalorieConsumptionParameter("Бег (8 км/ч)",  7 ),
			new CalorieConsumptionParameter("Бег (16 км/ч)", 11),
			new CalorieConsumptionParameter("Бег по пересеченной местности", 9),
			new CalorieConsumptionParameter("Бег вверх и вниз по ступенькам",  8),
			new CalorieConsumptionParameter("Бег вверх по ступенькам", 13)
		};

		// Возможные виды бега
		public CalorieConsumptionParameter[] Variants
		{
			get
			{
				return _variants;
			}
		}

		private int _variantIndex = -1;		
		
		// Вариант бега для данной тренировки
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
				return "Бег";
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