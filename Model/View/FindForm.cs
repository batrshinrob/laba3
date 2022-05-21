using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;

namespace View
{
	public partial class FindForm : Form
	{
		public FindForm()
		{
			InitializeComponent();
			
			_activityVariantSelector.Items.AddRange(
				GetVariants(new RunCalorieConsumption()));
			_activityVariantSelector.Items.AddRange(
				GetVariants(new SwimCalorieConsumption()));
			_activityVariantSelector.Items.AddRange(
				GetVariants(new BarbellCalorieConsumption()));
		}

		// Варианты данной активности
		private string[] GetVariants(ICalorieConsumption consumption)
		{
			int variantCount = consumption.Variants.Count();
			string[] variants = new string[variantCount];
			for (int i = 0; i < variantCount; i++)
				variants[i] = consumption.Variants[i].Name;
			return variants;
		}

		// Данные для поиска
		private FindData _findData;
		public FindData FindData
		{
			get
			{
				return _findData;
			}
		}

		// Кнопка ОК
		private void OKClick(object sender, EventArgs e)
		{
			string[] strings = new string[6]
			{
				"",
				"",
				_tolleranceValue.Text,
				_massInput.Text,
				_timeInput.Text,
				_calorieConsumptionInput.Text
			};
			if (_activitySelector.SelectedIndex != -1)
				strings[0] = _activitySelector.SelectedItem.ToString();
			if (_activityVariantSelector.SelectedIndex != -1)
				strings[1] = _activityVariantSelector.SelectedItem.ToString();

			bool ok = false;
			for (int i = 0; i < 6; i++)
			{
				ok = (strings[i] != "");
				if (ok) break;
			}
			if (!ok)
			{
				MessageBox.Show(
					"По крайней мере одна строка поиска должна быть непустой.");
				DialogResult = DialogResult.None;
			}
			_findData = new FindData(strings);
		}
	}
}
