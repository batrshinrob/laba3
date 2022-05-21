namespace View
{
	partial class AddCalorieConsumptionForm
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
			this._activity = new System.Windows.Forms.Label();
			this._activitySelector = new System.Windows.Forms.ComboBox();
			this._mass = new System.Windows.Forms.Label();
			this._massInput = new System.Windows.Forms.TextBox();
			this._timeInput = new System.Windows.Forms.TextBox();
			this._time = new System.Windows.Forms.Label();
			this._ok = new System.Windows.Forms.Button();
			this._cancel = new System.Windows.Forms.Button();
#if (DEBUG)
			this._random = new System.Windows.Forms.Button();
#endif
			this._minutes = new System.Windows.Forms.Label();
			this._kg = new System.Windows.Forms.Label();
			this._activityVariant = new System.Windows.Forms.Label();
			this._activityVariantSelector = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// _activity
			// 
			this._activity.AutoSize = true;
			this._activity.Location = new System.Drawing.Point(12, 9);
			this._activity.Name = "_activity";
			this._activity.Size = new System.Drawing.Size(87, 13);
			this._activity.TabIndex = 0;
			this._activity.Text = "Вид активности";
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
			this._activitySelector.Location = new System.Drawing.Point(159, 6);
			this._activitySelector.Name = "_activitySelector";
			this._activitySelector.Size = new System.Drawing.Size(279, 21);
			this._activitySelector.TabIndex = 1;
			this._activitySelector.SelectedIndexChanged += 
				new System.EventHandler(this.ActivitySelectorSelectedIndexChanged);
			// 
			// _mass
			// 
			this._mass.AutoSize = true;
			this._mass.Location = new System.Drawing.Point(12, 63);
			this._mass.Name = "_mass";
			this._mass.Size = new System.Drawing.Size(90, 13);
			this._mass.TabIndex = 2;
			this._mass.Text = "Масса человека";
			// 
			// _massInput
			// 
			this._massInput.Anchor = ((System.Windows.Forms.AnchorStyles)
				(((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._massInput.Location = new System.Drawing.Point(159, 60);
			this._massInput.Name = "_massInput";
			this._massInput.Size = new System.Drawing.Size(44, 20);
			this._massInput.TabIndex = 3;
			// 
			// _timeInput
			// 
			this._timeInput.Anchor = ((System.Windows.Forms.AnchorStyles)
				(((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._timeInput.Location = new System.Drawing.Point(159, 86);
			this._timeInput.Name = "_timeInput";
			this._timeInput.Size = new System.Drawing.Size(44, 20);
			this._timeInput.TabIndex = 4;
			// 
			// _time
			// 
			this._time.AutoSize = true;
			this._time.Location = new System.Drawing.Point(9, 89);
			this._time.Name = "_time";
			this._time.Size = new System.Drawing.Size(141, 13);
			this._time.TabIndex = 5;
			this._time.Text = "Длительность активности";
			// 
			// _ok
			// 
			this._ok.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._ok.Location = new System.Drawing.Point(12, 140);
			this._ok.Name = "_ok";
			this._ok.Size = new System.Drawing.Size(75, 23);
			this._ok.TabIndex = 7;
			this._ok.Text = "OK";
			this._ok.UseVisualStyleBackColor = true;
			this._ok.Click += new System.EventHandler(this.OKClick);
			// 
			// _cancel
			// 
			this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancel.Location = new System.Drawing.Point(93, 140);
			this._cancel.Name = "_cancel";
			this._cancel.Size = new System.Drawing.Size(75, 23);
			this._cancel.TabIndex = 8;
			this._cancel.Text = "Отмена";
			this._cancel.UseVisualStyleBackColor = true;
#if (DEBUG)
			// 
			// _random
			// 
			this._random.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._random.Location = new System.Drawing.Point(174, 140);
			this._random.Name = "_random";
			this._random.Size = new System.Drawing.Size(132, 23);
			this._random.TabIndex = 9;
			this._random.Text = "Случайные данные";
			this._random.UseVisualStyleBackColor = true;
			this._random.Click += new System.EventHandler(this.RandomClick);
#endif
			// 
			// _minutes
			// 
			this._minutes.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Right)));
			this._minutes.AutoSize = true;
			this._minutes.Location = new System.Drawing.Point(209, 89);
			this._minutes.Name = "_minutes";
			this._minutes.Size = new System.Drawing.Size(30, 13);
			this._minutes.TabIndex = 10;
			this._minutes.Text = "мин.";
			// 
			// _kg
			// 
			this._kg.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Right)));
			this._kg.AutoSize = true;
			this._kg.Location = new System.Drawing.Point(209, 63);
			this._kg.Name = "_kg";
			this._kg.Size = new System.Drawing.Size(18, 13);
			this._kg.TabIndex = 11;
			this._kg.Text = "кг";
			// 
			// _activityVariant
			// 
			this._activityVariant.AutoSize = true;
			this._activityVariant.Location = new System.Drawing.Point(12, 36);
			this._activityVariant.Name = "_activityVariant";
			this._activityVariant.Size = new System.Drawing.Size(110, 13);
			this._activityVariant.TabIndex = 12;
			this._activityVariant.Text = "Вариант активности";
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
				new System.Drawing.Point(159, 33);
			this._activityVariantSelector.Name = "_activityVariantSelector";
			this._activityVariantSelector.Size = new System.Drawing.Size(279, 21);
			this._activityVariantSelector.TabIndex = 13;
			// 
			// AddCalorieConsumptionForm
			// 
			this.AcceptButton = this._ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._cancel;
			this.ClientSize = new System.Drawing.Size(450, 175);
			this.Controls.Add(this._activityVariantSelector);
			this.Controls.Add(this._activityVariant);
			this.Controls.Add(this._kg);
			this.Controls.Add(this._minutes);
			this.Controls.Add(this._random);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._ok);
			this.Controls.Add(this._time);
			this.Controls.Add(this._timeInput);
			this.Controls.Add(this._massInput);
			this.Controls.Add(this._mass);
			this.Controls.Add(this._activitySelector);
			this.Controls.Add(this._activity);
			this.MinimumSize = new System.Drawing.Size(333, 190);
			this.Name = "AddCalorieConsumptionForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Добавить затраты калорий";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _activity;
		private System.Windows.Forms.ComboBox _activitySelector;
		private System.Windows.Forms.Label _mass;
		private System.Windows.Forms.TextBox _massInput;
		private System.Windows.Forms.TextBox _timeInput;
		private System.Windows.Forms.Label _time;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Button _cancel;
		private System.Windows.Forms.Button _random;
		private System.Windows.Forms.Label _minutes;
		private System.Windows.Forms.Label _kg;
		private System.Windows.Forms.Label _activityVariant;
		private System.Windows.Forms.ComboBox _activityVariantSelector;
	}
}