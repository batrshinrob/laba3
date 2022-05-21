namespace View
{
	partial class FindForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">
		/// true if managed resources should be disposed; otherwise, false.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._activityVariantSelector = new System.Windows.Forms.ComboBox();
			this._activityVariant = new System.Windows.Forms.Label();
			this._kg = new System.Windows.Forms.Label();
			this._minutes = new System.Windows.Forms.Label();
			this._cancel = new System.Windows.Forms.Button();
			this._ok = new System.Windows.Forms.Button();
			this._time = new System.Windows.Forms.Label();
			this._timeInput = new System.Windows.Forms.TextBox();
			this._massInput = new System.Windows.Forms.TextBox();
			this._mass = new System.Windows.Forms.Label();
			this._activitySelector = new System.Windows.Forms.ComboBox();
			this._activity = new System.Windows.Forms.Label();
			this._calorieConsumption = new System.Windows.Forms.Label();
			this._calorieConsumptionInput = new System.Windows.Forms.TextBox();
			this.kkalories = new System.Windows.Forms.Label();
			this._tollerance = new System.Windows.Forms.Label();
			this._tolleranceValue = new System.Windows.Forms.TextBox();
			this._percent = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _activityVariantSelector
			// 
			this._activityVariantSelector.Anchor = 
				((System.Windows.Forms.AnchorStyles)
				(((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._activityVariantSelector.DropDownStyle = 
				System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._activityVariantSelector.FormattingEnabled = true;
			this._activityVariantSelector.Location =
				new System.Drawing.Point(161, 36);
			this._activityVariantSelector.Name = "_activityVariantSelector";
			this._activityVariantSelector.Size = new System.Drawing.Size(279, 21);
			this._activityVariantSelector.TabIndex = 25;
			// 
			// _activityVariant
			// 
			this._activityVariant.AutoSize = true;
			this._activityVariant.Location = new System.Drawing.Point(14, 39);
			this._activityVariant.Name = "_activityVariant";
			this._activityVariant.Size = new System.Drawing.Size(110, 13);
			this._activityVariant.TabIndex = 24;
			this._activityVariant.Text = "Вариант активности";
			// 
			// _kg
			// 
			this._kg.AutoSize = true;
			this._kg.Location = new System.Drawing.Point(211, 66);
			this._kg.Name = "_kg";
			this._kg.Size = new System.Drawing.Size(18, 13);
			this._kg.TabIndex = 23;
			this._kg.Text = "кг";
			// 
			// _minutes
			// 
			this._minutes.AutoSize = true;
			this._minutes.Location = new System.Drawing.Point(211, 92);
			this._minutes.Name = "_minutes";
			this._minutes.Size = new System.Drawing.Size(30, 13);
			this._minutes.TabIndex = 22;
			this._minutes.Text = "мин.";
			// 
			// _cancel
			// 
			this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancel.Location = new System.Drawing.Point(95, 161);
			this._cancel.Name = "_cancel";
			this._cancel.Size = new System.Drawing.Size(75, 23);
			this._cancel.TabIndex = 21;
			this._cancel.Text = "Отмена";
			this._cancel.UseVisualStyleBackColor = true;
			// 
			// _ok
			// 
			this._ok.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._ok.Location = new System.Drawing.Point(14, 161);
			this._ok.Name = "_ok";
			this._ok.Size = new System.Drawing.Size(75, 23);
			this._ok.TabIndex = 20;
			this._ok.Text = "OK";
			this._ok.UseVisualStyleBackColor = true;
			this._ok.Click += new System.EventHandler(this.OKClick);
			// 
			// _time
			// 
			this._time.AutoSize = true;
			this._time.Location = new System.Drawing.Point(11, 92);
			this._time.Name = "_time";
			this._time.Size = new System.Drawing.Size(141, 13);
			this._time.TabIndex = 19;
			this._time.Text = "Длительность активности";
			// 
			// _timeInput
			// 
			this._timeInput.Location = new System.Drawing.Point(161, 89);
			this._timeInput.Name = "_timeInput";
			this._timeInput.Size = new System.Drawing.Size(44, 20);
			this._timeInput.TabIndex = 18;
			// 
			// _massInput
			// 
			this._massInput.BackColor = System.Drawing.SystemColors.Window;
			this._massInput.Location = new System.Drawing.Point(161, 63);
			this._massInput.Name = "_massInput";
			this._massInput.Size = new System.Drawing.Size(44, 20);
			this._massInput.TabIndex = 17;
			// 
			// _mass
			// 
			this._mass.AutoSize = true;
			this._mass.Location = new System.Drawing.Point(14, 66);
			this._mass.Name = "_mass";
			this._mass.Size = new System.Drawing.Size(90, 13);
			this._mass.TabIndex = 16;
			this._mass.Text = "Масса человека";
			// 
			// _activitySelector
			// 
			this._activitySelector.Anchor = ((System.Windows.Forms.AnchorStyles)
				(((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._activitySelector.DropDownStyle = 
				System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._activitySelector.FormattingEnabled = true;
			this._activitySelector.Items.AddRange(new object[] {
            "Бег",
            "Жим штанги",
            "Плавание"});
			this._activitySelector.Location = new System.Drawing.Point(161, 9);
			this._activitySelector.Name = "_activitySelector";
			this._activitySelector.Size = new System.Drawing.Size(279, 21);
			this._activitySelector.TabIndex = 15;
			// 
			// _activity
			// 
			this._activity.AutoSize = true;
			this._activity.Location = new System.Drawing.Point(14, 12);
			this._activity.Name = "_activity";
			this._activity.Size = new System.Drawing.Size(87, 13);
			this._activity.TabIndex = 14;
			this._activity.Text = "Вид активности";
			// 
			// _calorieConsumption
			// 
			this._calorieConsumption.AutoSize = true;
			this._calorieConsumption.Location = new System.Drawing.Point(14, 118);
			this._calorieConsumption.Name = "_calorieConsumption";
			this._calorieConsumption.Size = new System.Drawing.Size(95, 13);
			this._calorieConsumption.TabIndex = 28;
			this._calorieConsumption.Text = "Затраты калорий";
			// 
			// _calorieConsumptionInput
			// 
			this._calorieConsumptionInput.Location = new System.Drawing.Point(161, 115);
			this._calorieConsumptionInput.Name = "_calorieConsumptionInput";
			this._calorieConsumptionInput.Size = new System.Drawing.Size(80, 20);
			this._calorieConsumptionInput.TabIndex = 29;
			// 
			// kkalories
			// 
			this.kkalories.AutoSize = true;
			this.kkalories.Location = new System.Drawing.Point(247, 118);
			this.kkalories.Name = "kkalories";
			this.kkalories.Size = new System.Drawing.Size(31, 13);
			this.kkalories.TabIndex = 30;
			this.kkalories.Text = "ккал";
			// 
			// _tollerance
			// 
			this._tollerance.AutoSize = true;
			this._tollerance.Location = new System.Drawing.Point(324, 66);
			this._tollerance.Name = "_tollerance";
			this._tollerance.Size = new System.Drawing.Size(45, 13);
			this._tollerance.TabIndex = 31;
			this._tollerance.Text = "Допуск";
			// 
			// _tolleranceValue
			// 
			this._tolleranceValue.BackColor = System.Drawing.SystemColors.Window;
			this._tolleranceValue.Location = new System.Drawing.Point(375, 63);
			this._tolleranceValue.Name = "_tolleranceValue";
			this._tolleranceValue.Size = new System.Drawing.Size(44, 20);
			this._tolleranceValue.TabIndex = 32;
			// 
			// _percent
			// 
			this._percent.AutoSize = true;
			this._percent.Location = new System.Drawing.Point(425, 66);
			this._percent.Name = "_percent";
			this._percent.Size = new System.Drawing.Size(15, 13);
			this._percent.TabIndex = 33;
			this._percent.Text = "%";
			// 
			// FindForm
			// 
			this.AcceptButton = this._ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._cancel;
			this.ClientSize = new System.Drawing.Size(450, 193);
			this.Controls.Add(this._percent);
			this.Controls.Add(this._tolleranceValue);
			this.Controls.Add(this._tollerance);
			this.Controls.Add(this.kkalories);
			this.Controls.Add(this._calorieConsumptionInput);
			this.Controls.Add(this._calorieConsumption);
			this.Controls.Add(this._activityVariantSelector);
			this.Controls.Add(this._activityVariant);
			this.Controls.Add(this._kg);
			this.Controls.Add(this._minutes);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._ok);
			this.Controls.Add(this._time);
			this.Controls.Add(this._timeInput);
			this.Controls.Add(this._massInput);
			this.Controls.Add(this._mass);
			this.Controls.Add(this._activitySelector);
			this.Controls.Add(this._activity);
			this.MinimumSize = new System.Drawing.Size(400, 230);
			this.Name = "FindForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Поиск активностей по затратам калорий";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _activityVariantSelector;
		private System.Windows.Forms.Label _activityVariant;
		private System.Windows.Forms.Label _kg;
		private System.Windows.Forms.Label _minutes;
		private System.Windows.Forms.Button _cancel;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Label _time;
		private System.Windows.Forms.TextBox _timeInput;
		private System.Windows.Forms.TextBox _massInput;
		private System.Windows.Forms.Label _mass;
		private System.Windows.Forms.ComboBox _activitySelector;
		private System.Windows.Forms.Label _activity;
		private System.Windows.Forms.Label _calorieConsumption;
		private System.Windows.Forms.TextBox _calorieConsumptionInput;
		private System.Windows.Forms.Label kkalories;
		private System.Windows.Forms.Label _tollerance;
		private System.Windows.Forms.TextBox _tolleranceValue;
		private System.Windows.Forms.Label _percent;
	}
}