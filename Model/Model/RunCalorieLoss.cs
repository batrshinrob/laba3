using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
	/// <summary>
	/// Метод сброса калорий - бег
	/// </summary>
	[Serializable]
	public class RunCalorieLoss : ICalorieLoss
	{
		/// <summary>
		/// Масса занимающегося
		/// </summary>
		private float _mass;

		/// <summary>
		/// Свойство масса занимающегося
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
		/// Скорость бега
		/// </summary>
		private float _velocity;

		/// <summary>
		/// Скорость бега (свойство)
		/// </summary>
		public float Velocity
		{
			get
			{
				return _velocity;
			}
			set
			{
				Validator.ValidateLite(
					value, 5, "Скорость должна быть не менее 5 км/ч и быть конечной.");
				_velocity = value;
			}
		}

		/// <summary>
		/// Потеря калорий за занятие
		/// </summary>
		public float CalorieLoss
		{
			get
			{
				return _mass * _time * 60 * (18 * _velocity - 20) / 1000;
			}
		}

		/// <summary>
		/// Название метода сброса калорий
		/// </summary>
		public string Method
		{
			get
			{
				return "Бег";
			}
		}

		/// <summary>
		/// Параметры бега
		/// </summary>
		public string Parameters
		{
			get
			{
				return $"{Method} со скоростью {_velocity} км/ч в течение {_time} минут";
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
