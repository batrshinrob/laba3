namespace View
{
	partial class CalorieLossComputeForm
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
			this._trainsGroup = new System.Windows.Forms.GroupBox();
			this._trains = new System.Windows.Forms.DataGridView();
			this._trainType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._parameters = 
				new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._calorieLoss = 
				new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._buttons = new System.Windows.Forms.Panel();
			this._load = new System.Windows.Forms.Button();
			this._save = new System.Windows.Forms.Button();
			this._search = new System.Windows.Forms.Button();
			this._remove = new System.Windows.Forms.Button();
			this._add = new System.Windows.Forms.Button();
			this._list = new System.Windows.Forms.GroupBox();
			this._trainings = new System.Windows.Forms.ListBox();
			this._openDialog = new System.Windows.Forms.OpenFileDialog();
			this._saveDialog = new System.Windows.Forms.SaveFileDialog();
			this._trainsGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._trains)).BeginInit();
			this._buttons.SuspendLayout();
			this._list.SuspendLayout();
			this.SuspendLayout();
			// 
			// _trainsGroup
			// 
			this._trainsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)
				((((System.Windows.Forms.AnchorStyles.Top | 
				System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._trainsGroup.Controls.Add(this._trains);
			this._trainsGroup.Location = new System.Drawing.Point(0, 0);
			this._trainsGroup.Name = "_trainsGroup";
			this._trainsGroup.Size = new System.Drawing.Size(564, 195);
			this._trainsGroup.TabIndex = 0;
			this._trainsGroup.TabStop = false;
			this._trainsGroup.Text = "Тренировки";
			// 
			// _trains
			// 
			this._trains.ColumnHeadersHeightSizeMode =
				System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.
				AutoSize;
			this._trains.Columns.AddRange(
				new System.Windows.Forms.DataGridViewColumn[] {
            this._trainType,
            this._mass,
            this._time,
            this._parameters,
            this._calorieLoss});
			this._trains.Dock = System.Windows.Forms.DockStyle.Fill;
			this._trains.Location = new System.Drawing.Point(3, 16);
			this._trains.Name = "_trains";
			this._trains.ReadOnly = true;
			this._trains.SelectionMode = 
				System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this._trains.ShowRowErrors = false;
			this._trains.Size = new System.Drawing.Size(558, 176);
			this._trains.TabIndex = 0;
			this._trains.SelectionChanged += 
				new System.EventHandler(this.TrainsSelectionChanged);
			// 
			// _trainType
			// 
			this._trainType.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this._trainType.HeaderText = "Тип тренировки";
			this._trainType.Name = "_trainType";
			this._trainType.ReadOnly = true;
			// 
			// _mass
			// 
			this._mass.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this._mass.HeaderText = "Масса тренирующегося, кг";
			this._mass.Name = "_mass";
			this._mass.ReadOnly = true;
			// 
			// _time
			// 
			this._time.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this._time.HeaderText = "Длительность, минуты";
			this._time.Name = "_time";
			this._time.ReadOnly = true;
			// 
			// _parameters
			// 
			this._parameters.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this._parameters.HeaderText = "Параметры тренировки";
			this._parameters.Name = "_parameters";
			this._parameters.ReadOnly = true;
			// 
			// _calorieLoss
			// 
			this._calorieLoss.AutoSizeMode = 
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this._calorieLoss.HeaderText = "Расход калорий, ккал";
			this._calorieLoss.Name = "_calorieLoss";
			this._calorieLoss.ReadOnly = true;
			// 
			// _buttons
			// 
			this._buttons.Anchor = ((System.Windows.Forms.AnchorStyles)
				((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left)));
			this._buttons.Controls.Add(this._load);
			this._buttons.Controls.Add(this._save);
			this._buttons.Controls.Add(this._search);
			this._buttons.Controls.Add(this._remove);
			this._buttons.Controls.Add(this._add);
			this._buttons.Location = new System.Drawing.Point(12, 201);
			this._buttons.Name = "_buttons";
			this._buttons.Size = new System.Drawing.Size(200, 144);
			this._buttons.TabIndex = 1;
			// 
			// _load
			// 
			this._load.Location = new System.Drawing.Point(3, 119);
			this._load.Name = "_load";
			this._load.Size = new System.Drawing.Size(194, 23);
			this._load.TabIndex = 1;
			this._load.Text = "Загрузить";
			this._load.UseVisualStyleBackColor = true;
			this._load.Click += new System.EventHandler(this.LoadClick);
			// 
			// _save
			// 
			this._save.Location = new System.Drawing.Point(3, 90);
			this._save.Name = "_save";
			this._save.Size = new System.Drawing.Size(194, 23);
			this._save.TabIndex = 1;
			this._save.Text = "Сохранить";
			this._save.UseVisualStyleBackColor = true;
			this._save.Click += new System.EventHandler(this.SaveClick);
			// 
			// _search
			// 
			this._search.Location = new System.Drawing.Point(3, 61);
			this._search.Name = "_search";
			this._search.Size = new System.Drawing.Size(194, 23);
			this._search.TabIndex = 1;
			this._search.Text = "Поиск";
			this._search.UseVisualStyleBackColor = true;
			this._search.Click += new System.EventHandler(this.SearchClick);
			// 
			// _remove
			// 
			this._remove.Location = new System.Drawing.Point(3, 32);
			this._remove.Name = "_remove";
			this._remove.Size = new System.Drawing.Size(194, 23);
			this._remove.TabIndex = 3;
			this._remove.Text = "Удалить тренировку";
			this._remove.UseVisualStyleBackColor = true;
			this._remove.Click += new System.EventHandler(this.RemoveClick);
			// 
			// _add
			// 
			this._add.Location = new System.Drawing.Point(3, 3);
			this._add.Name = "_add";
			this._add.Size = new System.Drawing.Size(194, 23);
			this._add.TabIndex = 2;
			this._add.Text = "Добавить тренировку";
			this._add.UseVisualStyleBackColor = true;
			this._add.Click += new System.EventHandler(this.AddClick);
			// 
			// _list
			// 
			this._list.Anchor = ((System.Windows.Forms.AnchorStyles)
				(((System.Windows.Forms.AnchorStyles.Bottom | 
				System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._list.Controls.Add(this._trainings);
			this._list.Location = new System.Drawing.Point(218, 204);
			this._list.Name = "_list";
			this._list.Size = new System.Drawing.Size(334, 149);
			this._list.TabIndex = 2;
			this._list.TabStop = false;
			this._list.Text = "Список тренировок";
			// 
			// _trainings
			// 
			this._trainings.Dock = System.Windows.Forms.DockStyle.Fill;
			this._trainings.FormattingEnabled = true;
			this._trainings.Location = new System.Drawing.Point(3, 16);
			this._trainings.Name = "_trainings";
			this._trainings.SelectionMode = 
				System.Windows.Forms.SelectionMode.MultiExtended;
			this._trainings.Size = new System.Drawing.Size(328, 130);
			this._trainings.TabIndex = 0;
			this._trainings.SelectedIndexChanged +=
				new System.EventHandler(this.TrainingsSelectedIndexChanged);
			// 
			// _openDialog
			// 
			this._openDialog.DefaultExt = "cal";
			this._openDialog.Filter = 
				"Файлы данных расхода калорий (*.cal)|*.cal|Все файлы (*.*)|*.*";
			// 
			// _saveDialog
			// 
			this._saveDialog.DefaultExt = "cal";
			this._saveDialog.Filter = 
				"Файлы данных расхода калорий (*.cal)|*.cal|Все файлы (*.*)|*.*";
			// 
			// CalorieLossComputeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 357);
			this.Controls.Add(this._list);
			this.Controls.Add(this._buttons);
			this.Controls.Add(this._trainsGroup);
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "CalorieLossComputeForm";
			this.Text = "Расчет расхода калорий при тренировках";
			this._trainsGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._trains)).EndInit();
			this._buttons.ResumeLayout(false);
			this._list.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox _trainsGroup;
		private System.Windows.Forms.Panel _buttons;
		private System.Windows.Forms.Button _remove;
		private System.Windows.Forms.Button _add;
		private System.Windows.Forms.GroupBox _list;
		private System.Windows.Forms.ListBox _trainings;
		private System.Windows.Forms.DataGridView _trains;
		private System.Windows.Forms.Button _search;
		private System.Windows.Forms.Button _load;
		private System.Windows.Forms.Button _save;
		private System.Windows.Forms.OpenFileDialog _openDialog;
		private System.Windows.Forms.SaveFileDialog _saveDialog;
		private System.Windows.Forms.DataGridViewTextBoxColumn _trainType;
		private System.Windows.Forms.DataGridViewTextBoxColumn _mass;
		private System.Windows.Forms.DataGridViewTextBoxColumn _time;
		private System.Windows.Forms.DataGridViewTextBoxColumn _parameters;
		private System.Windows.Forms.DataGridViewTextBoxColumn _calorieLoss;
	}
}