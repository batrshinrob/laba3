namespace View
{
	partial class SearchForm
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
			this._massName = new System.Windows.Forms.Label();
			this._massFrom = new System.Windows.Forms.TextBox();
			this._timeName = new System.Windows.Forms.Label();
			this._timeFrom = new System.Windows.Forms.TextBox();
			this._calorieFrom = new System.Windows.Forms.TextBox();
			this._caloryLossName = new System.Windows.Forms.Label();
			this._type = new System.Windows.Forms.ComboBox();
			this._trainingTypeName = new System.Windows.Forms.Label();
			this._text = new System.Windows.Forms.TextBox();
			this._textName = new System.Windows.Forms.Label();
			this._massToName = new System.Windows.Forms.Label();
			this._timeToName = new System.Windows.Forms.Label();
			this._lossToName = new System.Windows.Forms.Label();
			this._calorieTo = new System.Windows.Forms.TextBox();
			this._timeTo = new System.Windows.Forms.TextBox();
			this._massTo = new System.Windows.Forms.TextBox();
			this._ok = new System.Windows.Forms.Button();
			this._cancel = new System.Windows.Forms.Button();
			this._kilogram = new System.Windows.Forms.Label();
			this._minutes = new System.Windows.Forms.Label();
			this._kiloCalory = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _massName
			// 
			this._massName.AutoSize = true;
			this._massName.Location = new System.Drawing.Point(12, 9);
			this._massName.Name = "_massName";
			this._massName.Size = new System.Drawing.Size(144, 13);
			this._massName.TabIndex = 0;
			this._massName.Text = "Масса занимающегося от ";
			// 
			// _massFrom
			// 
			this._massFrom.Location = new System.Drawing.Point(189, 6);
			this._massFrom.Name = "_massFrom";
			this._massFrom.Size = new System.Drawing.Size(84, 20);
			this._massFrom.TabIndex = 1;
			// 
			// _timeName
			// 
			this._timeName.AutoSize = true;
			this._timeName.Location = new System.Drawing.Point(12, 35);
			this._timeName.Name = "_timeName";
			this._timeName.Size = new System.Drawing.Size(101, 13);
			this._timeName.TabIndex = 2;
			this._timeName.Text = "Время занятий от ";
			// 
			// _timeFrom
			// 
			this._timeFrom.Location = new System.Drawing.Point(189, 32);
			this._timeFrom.Name = "_timeFrom";
			this._timeFrom.Size = new System.Drawing.Size(84, 20);
			this._timeFrom.TabIndex = 3;
			// 
			// _calorieFrom
			// 
			this._calorieFrom.Location = new System.Drawing.Point(189, 58);
			this._calorieFrom.Name = "_calorieFrom";
			this._calorieFrom.Size = new System.Drawing.Size(84, 20);
			this._calorieFrom.TabIndex = 4;
			// 
			// _caloryLossName
			// 
			this._caloryLossName.AutoSize = true;
			this._caloryLossName.Location = new System.Drawing.Point(12, 61);
			this._caloryLossName.Name = "_caloryLossName";
			this._caloryLossName.Size = new System.Drawing.Size(105, 13);
			this._caloryLossName.TabIndex = 5;
			this._caloryLossName.Text = "Расход калорий от ";
			// 
			// _type
			// 
			this._type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._type.FormattingEnabled = true;
			this._type.Items.AddRange(new object[] {
            "Любая",
            "Бег",
            "Плавание",
            "Жим штанги"});
			this._type.Location = new System.Drawing.Point(189, 84);
			this._type.Name = "_type";
			this._type.Size = new System.Drawing.Size(236, 21);
			this._type.TabIndex = 6;
			this._type.TabStop = false;
			// 
			// _trainingTypeName
			// 
			this._trainingTypeName.AutoSize = true;
			this._trainingTypeName.Location = new System.Drawing.Point(12, 87);
			this._trainingTypeName.Name = "_trainingTypeName";
			this._trainingTypeName.Size = new System.Drawing.Size(88, 13);
			this._trainingTypeName.TabIndex = 7;
			this._trainingTypeName.Text = "Тип тренировки";
			// 
			// _text
			// 
			this._text.Location = new System.Drawing.Point(189, 111);
			this._text.Name = "_text";
			this._text.Size = new System.Drawing.Size(236, 20);
			this._text.TabIndex = 8;
			// 
			// _textName
			// 
			this._textName.AutoSize = true;
			this._textName.Location = new System.Drawing.Point(12, 114);
			this._textName.Name = "_textName";
			this._textName.Size = new System.Drawing.Size(171, 13);
			this._textName.TabIndex = 9;
			this._textName.Text = "Текст в параметрах тренировки";
			// 
			// _massToName
			// 
			this._massToName.AutoSize = true;
			this._massToName.Location = new System.Drawing.Point(279, 9);
			this._massToName.Name = "_massToName";
			this._massToName.Size = new System.Drawing.Size(19, 13);
			this._massToName.TabIndex = 10;
			this._massToName.Text = "до";
			// 
			// _timeToName
			// 
			this._timeToName.AutoSize = true;
			this._timeToName.Location = new System.Drawing.Point(279, 35);
			this._timeToName.Name = "_timeToName";
			this._timeToName.Size = new System.Drawing.Size(19, 13);
			this._timeToName.TabIndex = 11;
			this._timeToName.Text = "до";
			// 
			// _lossToName
			// 
			this._lossToName.AutoSize = true;
			this._lossToName.Location = new System.Drawing.Point(279, 61);
			this._lossToName.Name = "_lossToName";
			this._lossToName.Size = new System.Drawing.Size(19, 13);
			this._lossToName.TabIndex = 12;
			this._lossToName.Text = "до";
			// 
			// _calorieTo
			// 
			this._calorieTo.Location = new System.Drawing.Point(304, 58);
			this._calorieTo.Name = "_calorieTo";
			this._calorieTo.Size = new System.Drawing.Size(84, 20);
			this._calorieTo.TabIndex = 15;
			// 
			// _timeTo
			// 
			this._timeTo.Location = new System.Drawing.Point(304, 32);
			this._timeTo.Name = "_timeTo";
			this._timeTo.Size = new System.Drawing.Size(84, 20);
			this._timeTo.TabIndex = 14;
			// 
			// _massTo
			// 
			this._massTo.Location = new System.Drawing.Point(304, 6);
			this._massTo.Name = "_massTo";
			this._massTo.Size = new System.Drawing.Size(84, 20);
			this._massTo.TabIndex = 13;
			// 
			// _ok
			// 
			this._ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._ok.Location = new System.Drawing.Point(15, 139);
			this._ok.Name = "_ok";
			this._ok.Size = new System.Drawing.Size(75, 23);
			this._ok.TabIndex = 16;
			this._ok.Text = "OK";
			this._ok.UseVisualStyleBackColor = true;
			this._ok.Click += new System.EventHandler(this.OkClick);
			// 
			// _cancel
			// 
			this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancel.Location = new System.Drawing.Point(350, 139);
			this._cancel.Name = "_cancel";
			this._cancel.Size = new System.Drawing.Size(75, 23);
			this._cancel.TabIndex = 17;
			this._cancel.Text = "Отмена";
			this._cancel.UseVisualStyleBackColor = true;
			// 
			// _kilogram
			// 
			this._kilogram.AutoSize = true;
			this._kilogram.Location = new System.Drawing.Point(394, 9);
			this._kilogram.Name = "_kilogram";
			this._kilogram.Size = new System.Drawing.Size(18, 13);
			this._kilogram.TabIndex = 18;
			this._kilogram.Text = "кг";
			// 
			// _minutes
			// 
			this._minutes.AutoSize = true;
			this._minutes.Location = new System.Drawing.Point(394, 35);
			this._minutes.Name = "_minutes";
			this._minutes.Size = new System.Drawing.Size(37, 13);
			this._minutes.TabIndex = 19;
			this._minutes.Text = "минут";
			// 
			// _kiloCalory
			// 
			this._kiloCalory.AutoSize = true;
			this._kiloCalory.Location = new System.Drawing.Point(394, 61);
			this._kiloCalory.Name = "_kiloCalory";
			this._kiloCalory.Size = new System.Drawing.Size(31, 13);
			this._kiloCalory.TabIndex = 20;
			this._kiloCalory.Text = "ккал";
			// 
			// SearchForm
			// 
			this.AcceptButton = this._ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._cancel;
			this.ClientSize = new System.Drawing.Size(434, 174);
			this.Controls.Add(this._kiloCalory);
			this.Controls.Add(this._minutes);
			this.Controls.Add(this._kilogram);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._ok);
			this.Controls.Add(this._calorieTo);
			this.Controls.Add(this._timeTo);
			this.Controls.Add(this._massTo);
			this.Controls.Add(this._lossToName);
			this.Controls.Add(this._timeToName);
			this.Controls.Add(this._massToName);
			this.Controls.Add(this._textName);
			this.Controls.Add(this._text);
			this.Controls.Add(this._trainingTypeName);
			this.Controls.Add(this._type);
			this.Controls.Add(this._caloryLossName);
			this.Controls.Add(this._calorieFrom);
			this.Controls.Add(this._timeFrom);
			this.Controls.Add(this._timeName);
			this.Controls.Add(this._massFrom);
			this.Controls.Add(this._massName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.Text = "Поиск данных";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _massName;
		private System.Windows.Forms.TextBox _massFrom;
		private System.Windows.Forms.Label _timeName;
		private System.Windows.Forms.TextBox _timeFrom;
		private System.Windows.Forms.TextBox _calorieFrom;
		private System.Windows.Forms.Label _caloryLossName;
		private System.Windows.Forms.ComboBox _type;
		private System.Windows.Forms.Label _trainingTypeName;
		private System.Windows.Forms.TextBox _text;
		private System.Windows.Forms.Label _textName;
		private System.Windows.Forms.Label _massToName;
		private System.Windows.Forms.Label _timeToName;
		private System.Windows.Forms.Label _lossToName;
		private System.Windows.Forms.TextBox _calorieTo;
		private System.Windows.Forms.TextBox _timeTo;
		private System.Windows.Forms.TextBox _massTo;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Button _cancel;
		private System.Windows.Forms.Label _kilogram;
		private System.Windows.Forms.Label _minutes;
		private System.Windows.Forms.Label _kiloCalory;
	}
}