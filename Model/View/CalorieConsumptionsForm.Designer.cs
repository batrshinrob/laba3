namespace View
{
	partial class CalorieConsumptionsForm
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
			this._calorieConsumptionsFrame = new System.Windows.Forms.GroupBox();
			this._calorieConsumptionsTable = 
				new System.Windows.Forms.DataGridView();
			this._activityName = 
				new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._activityVariant = 
				new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._mass = 
				new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._time = 
				new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._calorieConsumptionValue = 
				new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._panel = new System.Windows.Forms.Panel();
			this._label = new System.Windows.Forms.Label();
			this._calorieConsumptionsList = new System.Windows.Forms.ListBox();
			this._exit = new System.Windows.Forms.Button();
			this._load = new System.Windows.Forms.Button();
			this._save = new System.Windows.Forms.Button();
			this._find = new System.Windows.Forms.Button();
			this._remove = new System.Windows.Forms.Button();
			this._add = new System.Windows.Forms.Button();
			this._splitter = new System.Windows.Forms.Splitter();
			this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this._calorieConsumptionsFrame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)
				(this._calorieConsumptionsTable)).BeginInit();
			this._panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _calorieConsumptionsFrame
			// 
			this._calorieConsumptionsFrame.Controls.Add(
				this._calorieConsumptionsTable);
			this._calorieConsumptionsFrame.Dock = 
				System.Windows.Forms.DockStyle.Fill;
			this._calorieConsumptionsFrame.Location = 
				new System.Drawing.Point(0, 0);
			this._calorieConsumptionsFrame.Name = "_calorieConsumptionsFrame";
			this._calorieConsumptionsFrame.Size = 
				new System.Drawing.Size(608, 370);
			this._calorieConsumptionsFrame.TabIndex = 0;
			this._calorieConsumptionsFrame.TabStop = false;
			this._calorieConsumptionsFrame.Text = "Таблица затрат калорий";
			// 
			// _calorieConsumptionsTable
			// 
			this._calorieConsumptionsTable.AccessibleRole = 
				System.Windows.Forms.AccessibleRole.None;
			this._calorieConsumptionsTable.AllowUserToAddRows = false;
			this._calorieConsumptionsTable.AllowUserToDeleteRows = false;
			this._calorieConsumptionsTable.ColumnHeadersHeightSizeMode = 
				System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.
				AutoSize;
			this._calorieConsumptionsTable.Columns.AddRange(
				new System.Windows.Forms.DataGridViewColumn[] {
            this._activityName,
            this._activityVariant,
            this._mass,
            this._time,
            this._calorieConsumptionValue});
			this._calorieConsumptionsTable.Dock = 
				System.Windows.Forms.DockStyle.Fill;
			this._calorieConsumptionsTable.Location = 
				new System.Drawing.Point(3, 16);
			this._calorieConsumptionsTable.Name = "_calorieConsumptionsTable";
			this._calorieConsumptionsTable.ReadOnly = true;
			this._calorieConsumptionsTable.Size = 
				new System.Drawing.Size(602, 351);
			this._calorieConsumptionsTable.TabIndex = 1;
			this._calorieConsumptionsTable.SelectionChanged += 
				new System.EventHandler(
					this.CalorieConsumptionsTableSelectionChanged);
			// 
			// _activityName
			// 
			this._activityName.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this._activityName.HeaderText = "Вид активности";
			this._activityName.Name = "_activityName";
			this._activityName.ReadOnly = true;
			// 
			// _activityVariant
			// 
			this._activityVariant.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this._activityVariant.HeaderText = "Вариант активности";
			this._activityVariant.Name = "_activityVariant";
			this._activityVariant.ReadOnly = true;
			this._activityVariant.Width = 123;
			// 
			// _mass
			// 
			this._mass.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this._mass.HeaderText = "Масса человека, кг";
			this._mass.Name = "_mass";
			this._mass.ReadOnly = true;
			// 
			// _time
			// 
			this._time.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this._time.HeaderText = "Время активности, мин.";
			this._time.Name = "_time";
			this._time.ReadOnly = true;
			// 
			// _calorieConsumptionValue
			// 
			this._calorieConsumptionValue.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this._calorieConsumptionValue.HeaderText = "Затраты калорий, ккал";
			this._calorieConsumptionValue.Name = "_calorieConsumptionValue";
			this._calorieConsumptionValue.ReadOnly = true;
			// 
			// _panel
			// 
			this._panel.Controls.Add(this._label);
			this._panel.Controls.Add(this._calorieConsumptionsList);
			this._panel.Controls.Add(this._exit);
			this._panel.Controls.Add(this._load);
			this._panel.Controls.Add(this._save);
			this._panel.Controls.Add(this._find);
			this._panel.Controls.Add(this._remove);
			this._panel.Controls.Add(this._add);
			this._panel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._panel.Location = new System.Drawing.Point(0, 226);
			this._panel.Name = "_panel";
			this._panel.Size = new System.Drawing.Size(608, 144);
			this._panel.TabIndex = 1;
			// 
			// _label
			// 
			this._label.AutoSize = true;
			this._label.Location = new System.Drawing.Point(12, 3);
			this._label.Name = "_label";
			this._label.Size = new System.Drawing.Size(222, 13);
			this._label.TabIndex = 7;
			this._label.Text = "Список активностей по затратам калорий";
			// 
			// _calorieConsumptionsList
			// 
			this._calorieConsumptionsList.Anchor = 
				((System.Windows.Forms.AnchorStyles)
				((((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._calorieConsumptionsList.FormattingEnabled = true;
			this._calorieConsumptionsList.Location = 
				new System.Drawing.Point(3, 21);
			this._calorieConsumptionsList.Name = "_calorieConsumptionsList";
			this._calorieConsumptionsList.SelectionMode = 
				System.Windows.Forms.SelectionMode.MultiExtended;
			this._calorieConsumptionsList.Size = 
				new System.Drawing.Size(602, 82);
			this._calorieConsumptionsList.TabIndex = 6;
			this._calorieConsumptionsList.SelectedIndexChanged +=
				new System.EventHandler(
					this.CalorieConsumptionsListSelectedIndexChanged);
			// 
			// _exit
			// 
			this._exit.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._exit.Location = new System.Drawing.Point(417, 109);
			this._exit.Name = "_exit";
			this._exit.Size = new System.Drawing.Size(75, 23);
			this._exit.TabIndex = 5;
			this._exit.Text = "Выход";
			this._exit.UseVisualStyleBackColor = true;
			this._exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// _load
			// 
			this._load.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._load.Location = new System.Drawing.Point(336, 109);
			this._load.Name = "_load";
			this._load.Size = new System.Drawing.Size(75, 23);
			this._load.TabIndex = 4;
			this._load.Text = "Загрузить";
			this._load.UseVisualStyleBackColor = true;
			this._load.Click += new System.EventHandler(this.LoadClick);
			// 
			// _save
			// 
			this._save.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._save.Location = new System.Drawing.Point(255, 109);
			this._save.Name = "_save";
			this._save.Size = new System.Drawing.Size(75, 23);
			this._save.TabIndex = 3;
			this._save.Text = "Сохранить";
			this._save.UseVisualStyleBackColor = true;
			this._save.Click += new System.EventHandler(this.SaveClick);
			// 
			// _find
			// 
			this._find.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._find.Location = new System.Drawing.Point(174, 109);
			this._find.Name = "_find";
			this._find.Size = new System.Drawing.Size(75, 23);
			this._find.TabIndex = 2;
			this._find.Text = "Найти";
			this._find.UseVisualStyleBackColor = true;
			this._find.Click += new System.EventHandler(this.FindClick);
			// 
			// _remove
			// 
			this._remove.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._remove.Location = new System.Drawing.Point(93, 109);
			this._remove.Name = "_remove";
			this._remove.Size = new System.Drawing.Size(75, 23);
			this._remove.TabIndex = 1;
			this._remove.Text = "Удалить";
			this._remove.UseVisualStyleBackColor = true;
			this._remove.Click += new System.EventHandler(this.RemoveClick);
			// 
			// _add
			// 
			this._add.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._add.Location = new System.Drawing.Point(12, 109);
			this._add.Name = "_add";
			this._add.Size = new System.Drawing.Size(75, 23);
			this._add.TabIndex = 0;
			this._add.Text = "Добавить";
			this._add.UseVisualStyleBackColor = true;
			this._add.Click += new System.EventHandler(this.AddClick);
			// 
			// _splitter
			// 
			this._splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._splitter.Location = new System.Drawing.Point(0, 223);
			this._splitter.Name = "_splitter";
			this._splitter.Size = new System.Drawing.Size(608, 3);
			this._splitter.TabIndex = 2;
			this._splitter.TabStop = false;
			// 
			// _openFileDialog
			// 
			this._openFileDialog.DefaultExt = "clr";
			this._openFileDialog.Filter = 
				"Данные по затратам калорий (*.clr)|*.clr|Все файлы (*.*)|*.*";
			// 
			// _saveFileDialog
			// 
			this._saveFileDialog.DefaultExt = "clr";
			this._saveFileDialog.Filter = 
				"Данные по затратам калорий (*.clr)|*.clr|Все файлы (*.*)|*.*";
			// 
			// CalorieConsumptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 370);
			this.Controls.Add(this._splitter);
			this.Controls.Add(this._panel);
			this.Controls.Add(this._calorieConsumptionsFrame);
			this.MinimumSize = new System.Drawing.Size(516, 400);
			this.Name = "CalorieConsumptionsForm";
			this.Text = "Затраты калорий";
			this._calorieConsumptionsFrame.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)
				(this._calorieConsumptionsTable)).EndInit();
			this._panel.ResumeLayout(false);
			this._panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox _calorieConsumptionsFrame;
		private System.Windows.Forms.DataGridView _calorieConsumptionsTable;
		private System.Windows.Forms.Panel _panel;
		private System.Windows.Forms.Label _label;
		private System.Windows.Forms.ListBox _calorieConsumptionsList;
		private System.Windows.Forms.Button _exit;
		private System.Windows.Forms.Button _load;
		private System.Windows.Forms.Button _save;
		private System.Windows.Forms.Button _find;
		private System.Windows.Forms.Button _remove;
		private System.Windows.Forms.Button _add;
		private System.Windows.Forms.Splitter _splitter;
		private System.Windows.Forms.DataGridViewTextBoxColumn _activityName;
		private System.Windows.Forms.DataGridViewTextBoxColumn _activityVariant;
		private System.Windows.Forms.DataGridViewTextBoxColumn _mass;
		private System.Windows.Forms.DataGridViewTextBoxColumn _time;
		private System.Windows.Forms.DataGridViewTextBoxColumn
			_calorieConsumptionValue;
		private System.Windows.Forms.OpenFileDialog _openFileDialog;
		private System.Windows.Forms.SaveFileDialog _saveFileDialog;
	}
}

