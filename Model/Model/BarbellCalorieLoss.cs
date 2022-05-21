using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	/// <summary>
	/// Метод сброса калорий - жим штанги
	/// </summary>
	[Serializable]
	public class BarbellCalorieLoss : ICalorieLoss
	{
		/// <summary>
		/// Масса занимающегося
		/// </summary>
		private float _mass;

		/// <summary>
		/// Масса занимающегося (свойство)
		/// </summary>			
		public float Mass
		{
			get
			{
				return _mass;
			}
			set
			{
				Validator.ValidateMass(value);
				_mass = value;
			}
		}

		/// <summary>
		/// Вес штанги в килограммах
		/// </summary>
		private float _weight;

		/// <summary>
		/// Вес штанги в килограммах (свойство)
		/// </summary>
		public float Weight
		{
			get
			{
				return _weight;
			}
			set
			{
				Validator.ValidateLite(
					value, 1, "Вес штанги должен быть не менее 1 кг и конечным.");
				_weight = value;
			}
		}

		/// <summary>
		/// Число жимов штанги
		/// </summary>
		private int _count;

		/// <summary>
		/// Число жимов штанги (свойство)
		/// </summary>
		public int Count
		{
			get
			{
				return _count;
			}
			set
			{
				Validator.Validate(
					value, 0, "Число жимов штанги должно быть положительным.");
				_count = value;
			}
		}

		/// <summary>
		/// Время занятий
		/// </summary>
		private float _time;

		/// <summary>
		/// Свойство время занятий
		/// </summary>
		public float Time
		{
			get
			{
				return _time;
			}
			set
			{
				Validator.ValidateTime(value);
				_time = value;
			}
		}

		/// <summary>
		/// Потеря калорий за занятие
		/// </summary>
		public float CalorieLoss
		{
			get
			{
				float pyt = 0.5F;
				float ves_tela = _mass * 0.05F;
				float rabota1 = ((_count * 19.6F * (_weight + ves_tela))) * pyt;
				float rabotaFull = ((rabota1) * 0.239F) / 1000;
				rabotaFull /= 0.2F;
				var raznica_vesa = rabotaFull / 100 * ((_mass - 75));
				rabotaFull += raznica_vesa;
				return rabotaFull;
			}
		}

		/// <summary>
		/// Название метода сброса калорий
		/// </summary>
		public string Method
		{
			get
			{
				return "Жим штанги";
			}
		}

		/// <summary>
		/// Параметры жима штанги
		/// </summary>
		public string Parameters
		{
			get
			{
				return $"{Method} {Weight} кг {Count} раз";
			}
		}

		/// <summary>
		/// Представление в виде строки
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Parameters;
		}
	}
}
