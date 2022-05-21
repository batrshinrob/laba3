using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	// Валидатор
	public class Validator
	{
		// Валидация числового значения 
		public static void Validate(double value, double minValue, 
			double maxValue, string errorMessage)
		{
			if ((value < minValue) || ((value > maxValue) && (maxValue > minValue))
				|| double.IsNaN(value))
			{
				throw new Exception(errorMessage);
			}
		}

		// Валидация строки
		public static void Validate(string value)
		{
			if ((value == null) || (value == ""))
			{
				throw new Exception(
					"Строка не может быть пустой. Введите непустую строку.");
			}
		}
	}
}
