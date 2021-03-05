
namespace Laboratorio_1___repaso
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.dgvEmployeeInf = new System.Windows.Forms.DataGridView();
            this.dgvEmployeeMonthInf = new System.Windows.Forms.DataGridView();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.lbEmployeeSalary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdSelectFiles = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHourlyWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeMonthID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursOfTheMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeMonthInf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFromFile.Location = new System.Drawing.Point(293, 370);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(123, 50);
            this.btnLoadFromFile.TabIndex = 0;
            this.btnLoadFromFile.Text = "Cargar datos";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // dgvEmployeeInf
            // 
            this.dgvEmployeeInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.dgvHourlyWage});
            this.dgvEmployeeInf.Location = new System.Drawing.Point(12, 148);
            this.dgvEmployeeInf.Name = "dgvEmployeeInf";
            this.dgvEmployeeInf.ReadOnly = true;
            this.dgvEmployeeInf.Size = new System.Drawing.Size(323, 193);
            this.dgvEmployeeInf.TabIndex = 1;
            // 
            // dgvEmployeeMonthInf
            // 
            this.dgvEmployeeMonthInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeMonthInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeMonthID,
            this.HoursOfTheMonth,
            this.Month,
            this.TotalSalary});
            this.dgvEmployeeMonthInf.Location = new System.Drawing.Point(369, 148);
            this.dgvEmployeeMonthInf.Name = "dgvEmployeeMonthInf";
            this.dgvEmployeeMonthInf.Size = new System.Drawing.Size(335, 193);
            this.dgvEmployeeMonthInf.TabIndex = 2;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(91, 44);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(244, 27);
            this.cbEmpleados.TabIndex = 3;
            this.cbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cbEmpleados_SelectedIndexChanged);
            // 
            // lbEmployeeSalary
            // 
            this.lbEmployeeSalary.AutoSize = true;
            this.lbEmployeeSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeSalary.Location = new System.Drawing.Point(365, 46);
            this.lbEmployeeSalary.Name = "lbEmployeeSalary";
            this.lbEmployeeSalary.Size = new System.Drawing.Size(152, 19);
            this.lbEmployeeSalary.TabIndex = 4;
            this.lbEmployeeSalary.Text = "Sueldo del empleado: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empleado";
            // 
            // ofdSelectFiles
            // 
            this.ofdSelectFiles.FileName = "Archivo.emp o .memp";
            this.ofdSelectFiles.Filter = "Archivos de empleados .emp o .memp|*.emp;*.memp";
            this.ofdSelectFiles.Title = "Seleccione archivos de tipo empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Info. del empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Info. del mes del empleado";
            // 
            // EmployeeID
            // 
            this.EmployeeID.Frozen = true;
            this.EmployeeID.HeaderText = "Id";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 40;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Frozen = true;
            this.EmployeeName.HeaderText = "Nombre";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 120;
            // 
            // dgvHourlyWage
            // 
            this.dgvHourlyWage.Frozen = true;
            this.dgvHourlyWage.HeaderText = "Sueldo por hora";
            this.dgvHourlyWage.Name = "dgvHourlyWage";
            this.dgvHourlyWage.ReadOnly = true;
            this.dgvHourlyWage.Width = 120;
            // 
            // EmployeeMonthID
            // 
            this.EmployeeMonthID.Frozen = true;
            this.EmployeeMonthID.HeaderText = "Id";
            this.EmployeeMonthID.Name = "EmployeeMonthID";
            this.EmployeeMonthID.ReadOnly = true;
            this.EmployeeMonthID.Width = 40;
            // 
            // HoursOfTheMonth
            // 
            this.HoursOfTheMonth.Frozen = true;
            this.HoursOfTheMonth.HeaderText = "Horas del mes";
            this.HoursOfTheMonth.Name = "HoursOfTheMonth";
            this.HoursOfTheMonth.ReadOnly = true;
            this.HoursOfTheMonth.Width = 84;
            // 
            // Month
            // 
            this.Month.Frozen = true;
            this.Month.HeaderText = "Mes";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 84;
            // 
            // TotalSalary
            // 
            this.TotalSalary.Frozen = true;
            this.TotalSalary.HeaderText = "Salario";
            this.TotalSalary.Name = "TotalSalary";
            this.TotalSalary.ReadOnly = true;
            this.TotalSalary.Width = 84;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbEmployeeSalary);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.dgvEmployeeMonthInf);
            this.Controls.Add(this.dgvEmployeeInf);
            this.Controls.Add(this.btnLoadFromFile);
            this.Name = "Form1";
            this.Text = "Sueldo de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeMonthInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.DataGridView dgvEmployeeInf;
        private System.Windows.Forms.DataGridView dgvEmployeeMonthInf;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label lbEmployeeSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdSelectFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHourlyWage;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeMonthID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursOfTheMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSalary;
    }
}

