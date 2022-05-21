using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace View
{
	// Класс для поиска
	public class FindData
	{
		// Конструктор
		public FindData(string[] strings, double[] values)
		{
			if (strings.Length != 2)
				throw new Exception("Размерность массива строк поиска неверна.");

			if (values.Length != 4)
				throw new Exception("Размерность массива значений поиска неверна.");

			for (int i = 0; i < 2; i++)
			{
				if (strings[i] == null)
					throw new Exception("Строка массива данных поиска не может быть " +
						$"null (строка {i}).");
				_strings[i] = strings[i];
			}

			for (int i = 0; i < 4; i++)
			{
				 Validator.Validate(values[i], 0, 0,
					"Величина массива поиска не может иметь указанное значение " +
					$"(значение {i}).");
				_values[i] = values[i];
			}
		}

		// Конструктор по строкам
		public FindData(string[] strings)
		{
			if (strings.Length != 6)
				throw new Exception("Размерность массива строк поиска неверна.");

			for (int i = 0; i < 2; i++)
			{
				if (strings[i] == null)
					throw new Exception("Строка массива данных поиска не может быть " +
						$"null (строка {i}).");
				_strings[i] = strings[i];
			}

			for (int i = 0; i < 4; i++)
			{
				double value = 0;
				try
				{
					value = double.Parse(strings[i + 2]);
				}
				catch (FormatException exception)
				{ }

				Validator.Validate(value, 0, 0,
				 "Величина массива поиска не может иметь указанное значение " +
				 $"(значение {i}).");
				_values[i] = value;
			}
		}

		private string[] _strings = new string[2];
		private double[] _values = new double[4];

		// Строки для поиска
		public string[] Strings
		{
			get
			{
				return _strings;
			}
		}

		// Велчины для поиска
		public double[] Values
		{
			get
			{
				return _values;
			}
		}
	}
}
