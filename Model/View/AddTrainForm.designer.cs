namespace View
{
	partial class AddTrainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer _components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">
		/// true if managed resources should be disposed; otherwise, false.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (_components != null))
			{
				_components.Dispose();
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
			this._kind = new System.Windows.Forms.Label();
			this._trainingType = new System.Windows.Forms.ComboBox();
			this._trainingParameters = new System.Windows.Forms.GroupBox();
			this._particularParameters = new System.Windows.Forms.Panel();
			this._parameterSwitchName = new System.Windows.Forms.Label();
			this._parameterSwitch = new System.Windows.Forms.ComboBox();
			this._parameter2Value = new System.Windows.Forms.TextBox();
			this._parameter2Name = new System.Windows.Forms.Label();
			this._commonParameters = new System.Windows.Forms.Panel();
			this._parameter1Value = new System.Windows.Forms.TextBox();
			this._parameter1Name = new System.Windows.Forms.Label();
			this._massValue = new System.Windows.Forms.TextBox();
			this._massName = new System.Windows.Forms.Label();
			this._ok = new System.Windows.Forms.Button();
			this._cancel = new System.Windows.Forms.Button();
#if (DEBUG)
			this._random = new System.Windows.Forms.Button();
#endif
			this._trainingParameters.SuspendLayout();
			this._particularParameters.SuspendLayout();
			this._commonParameters.SuspendLayout();
			this.SuspendLayout();
			// 
			// _kind
			// 
			this._kind.AutoSize = true;
			this._kind.Location = new System.Drawing.Point(12, 9);
			this._kind.Name = "_kind";
			this._kind.Size = new System.Drawing.Size(91, 13);
			this._kind.TabIndex = 0;
			this._kind.Text = "Вид тренировки:";
			// 
			// _trainingType
			// 
			this._trainingType.Anchor = ((System.Windows.Forms.AnchorStyles)
				(((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._trainingType.DropDownStyle = 
				System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._trainingType.FormattingEnabled = true;
			this._trainingType.Items.AddRange(new object[] {
            "Бег",
            "Плавание",
            "Жим штанги"});
			this._trainingType.Location = new System.Drawing.Point(109, 6);
			this._trainingType.Name = "_trainingType";
			this._trainingType.Size = new System.Drawing.Size(297, 21);
			this._trainingType.TabIndex = 1;
			this._trainingType.SelectedIndexChanged += 
				new System.EventHandler(this.TrainingTypeSelectedIndexChanged);
			// 
			// groupBox1
			// 
			this._trainingParameters.Anchor = ((System.Windows.Forms.AnchorStyles)
				((((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._trainingParameters.Controls.Add(this._particularParameters);
			this._trainingParameters.Controls.Add(this._commonParameters);
			this._trainingParameters.Location = new System.Drawing.Point(12, 33);
			this._trainingParameters.Name = "groupBox1";
			this._trainingParameters.Size = new System.Drawing.Size(394, 123);
			this._trainingParameters.TabIndex = 2;
			this._trainingParameters.TabStop = false;
			this._trainingParameters.Text = "Параметры тренировки";
			// 
			// _particularParameters
			// 
			this._particularParameters.Anchor = ((System.Windows.Forms.AnchorStyles)
				((((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._particularParameters.Controls.Add(this._parameterSwitchName);
			this._particularParameters.Controls.Add(this._parameterSwitch);
			this._particularParameters.Controls.Add(this._parameter2Value);
			this._particularParameters.Controls.Add(this._parameter2Name);
			this._particularParameters.Location = new System.Drawing.Point(174, 19);
			this._particularParameters.Name = "_particularParameters";
			this._particularParameters.Size = new System.Drawing.Size(214, 95);
			this._particularParameters.TabIndex = 1;
			this._particularParameters.Visible = false;
			// 
			// _parameterSwitchName
			// 
			this._parameterSwitchName.AutoSize = true;
			this._parameterSwitchName.Location = new System.Drawing.Point(3, 52);
			this._parameterSwitchName.Name = "_parameterSwitchName";
			this._parameterSwitchName.Size = new System.Drawing.Size(91, 13);
			this._parameterSwitchName.TabIndex = 13;
			this._parameterSwitchName.Text = "Стиль плавания:";
			// 
			// _parameterSwitch
			// 
			this._parameterSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)
				(((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._parameterSwitch.DropDownStyle = 
				System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._parameterSwitch.FormattingEnabled = true;
			this._parameterSwitch.Items.AddRange(new object[] {
            "Плавание свободным стилем",
            "Плавание на спине",
            "Плавание кролем",
            "Плавание на волнах",
            "Плавание баттерфляем",
            "Плавание брасом",
            "Плавание на боку",
            "Плавание стоя",
            "Плавание с дыхательной трубкой",
            "Плавание с аквалангом"});
			this._parameterSwitch.Location = new System.Drawing.Point(6, 68);
			this._parameterSwitch.Name = "_parameterSwitch";
			this._parameterSwitch.Size = new System.Drawing.Size(205, 21);
			this._parameterSwitch.TabIndex = 12;
			// 
			// _parameter2Value
			// 
			this._parameter2Value.Location = new System.Drawing.Point(6, 25);
			this._parameter2Value.Name = "_parameter2Value";
			this._parameter2Value.Size = new System.Drawing.Size(146, 20);
			this._parameter2Value.TabIndex = 11;
			// 
			// _parameter2Name
			// 
			this._parameter2Name.AutoSize = true;
			this._parameter2Name.Location = new System.Drawing.Point(3, 9);
			this._parameter2Name.Name = "_parameter2Name";
			this._parameter2Name.Size = new System.Drawing.Size(83, 13);
			this._parameter2Name.TabIndex = 9;
			this._parameter2Name.Text = "Дистанция (м):";
			// 
			// _commonParameters
			// 
			this._commonParameters.Anchor = ((System.Windows.Forms.AnchorStyles)
				(((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this._commonParameters.Controls.Add(this._parameter1Value);
			this._commonParameters.Controls.Add(this._parameter1Name);
			this._commonParameters.Controls.Add(this._massValue);
			this._commonParameters.Controls.Add(this._massName);
			this._commonParameters.Location = new System.Drawing.Point(6, 19);
			this._commonParameters.Name = "_commonParameters";
			this._commonParameters.Size = new System.Drawing.Size(162, 95);
			this._commonParameters.TabIndex = 0;
			// 
			// _parameter1Value
			// 
			this._parameter1Value.Location = new System.Drawing.Point(9, 68);
			this._parameter1Value.Name = "_parameter1Value";
			this._parameter1Value.Size = new System.Drawing.Size(143, 20);
			this._parameter1Value.TabIndex = 12;
			this._parameter1Value.Visible = false;
			// 
			// _parameter1Name
			// 
			this._parameter1Name.AutoSize = true;
			this._parameter1Name.Location = new System.Drawing.Point(6, 52);
			this._parameter1Name.Name = "_parameter1Name";
			this._parameter1Name.Size = new System.Drawing.Size(151, 13);
			this._parameter1Name.TabIndex = 11;
			this._parameter1Name.Text = "Скорость плавания (м/мин);";
			this._parameter1Name.Visible = false;
			// 
			// _massValue
			// 
			this._massValue.Location = new System.Drawing.Point(6, 25);
			this._massValue.Name = "_massValue";
			this._massValue.Size = new System.Drawing.Size(146, 20);
			this._massValue.TabIndex = 6;
			// 
			// label1
			// 
			this._massName.AutoSize = true;
			this._massName.Location = new System.Drawing.Point(3, 9);
			this._massName.Name = "label1";
			this._massName.Size = new System.Drawing.Size(152, 13);
			this._massName.TabIndex = 4;
			this._massName.Text = "Масса тренирующегося (кг):";
			// 
			// _ok
			// 
			this._ok.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._ok.Location = new System.Drawing.Point(14, 162);
			this._ok.Name = "_ok";
			this._ok.Size = new System.Drawing.Size(75, 23);
			this._ok.TabIndex = 3;
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
			this._cancel.Location = new System.Drawing.Point(95, 162);
			this._cancel.Name = "_cancel";
			this._cancel.Size = new System.Drawing.Size(75, 23);
			this._cancel.TabIndex = 4;
			this._cancel.Text = "Отмена";
			this._cancel.UseVisualStyleBackColor = true;
#if (DEBUG)
			// 
			// _random
			// 
			this._random.Anchor = ((System.Windows.Forms.AnchorStyles)
				(((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._random.Location = new System.Drawing.Point(176, 162);
			this._random.Name = "_random";
			this._random.Size = new System.Drawing.Size(230, 23);
			this._random.TabIndex = 5;
			this._random.Text = "Сгенерировать случайные данные";
			this._random.UseVisualStyleBackColor = true;
			this._random.Click += new System.EventHandler(this.RandomClick);
#endif
			// 
			// AddTrainForm
			// 
			this.AcceptButton = this._ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._cancel;
			this.ClientSize = new System.Drawing.Size(418, 197);
#if (DEBUG)
			this.Controls.Add(this._random);
#endif
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._ok);
			this.Controls.Add(this._trainingParameters);
			this.Controls.Add(this._trainingType);
			this.Controls.Add(this._kind);
			this.MinimumSize = new System.Drawing.Size(400, 236);
			this.Name = "AddTrainForm";
			this.Text = "Добавление тренировки";
			this._trainingParameters.ResumeLayout(false);
			this._particularParameters.ResumeLayout(false);
			this._particularParameters.PerformLayout();
			this._commonParameters.ResumeLayout(false);
			this._commonParameters.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

#endregion

		private System.Windows.Forms.Label _kind;
		private System.Windows.Forms.ComboBox _trainingType;
		private System.Windows.Forms.GroupBox _trainingParameters;
		private System.Windows.Forms.Panel _particularParameters;
		private System.Windows.Forms.TextBox _parameter2Value;
		private System.Windows.Forms.Label _parameter2Name;
		private System.Windows.Forms.Panel _commonParameters;
		private System.Windows.Forms.TextBox _massValue;
		private System.Windows.Forms.Label _massName;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Button _cancel;
		private System.Windows.Forms.Label _parameterSwitchName;
		private System.Windows.Forms.ComboBox _parameterSwitch;
		private System.Windows.Forms.TextBox _parameter1Value;
		private System.Windows.Forms.Label _parameter1Name;
#if DEBUG
		private System.Windows.Forms.Button _random;
#endif
	}
}