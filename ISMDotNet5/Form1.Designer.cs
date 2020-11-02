namespace ISMDotNet5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRowsEnter = new System.Windows.Forms.Label();
            this.labelCollsEnter = new System.Windows.Forms.Label();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColls = new System.Windows.Forms.NumericUpDown();
            this.buttonBuildMatrix = new System.Windows.Forms.Button();
            this.labelPositiveElements = new System.Windows.Forms.Label();
            this.textBoxPositiveElements = new System.Windows.Forms.TextBox();
            this.labelMaxElem = new System.Windows.Forms.Label();
            this.textBoxMaxElem = new System.Windows.Forms.TextBox();
            this.labelCountWithputZeros = new System.Windows.Forms.Label();
            this.textBoxCountWithputZeros = new System.Windows.Forms.TextBox();
            this.labelCountColsWithZero = new System.Windows.Forms.Label();
            this.textBoxCountColsWithZero = new System.Windows.Forms.TextBox();
            this.labelMulWithoutNeg = new System.Windows.Forms.Label();
            this.dataGridViewMulWithoutNeg = new System.Windows.Forms.DataGridView();
            this.labelLongestRepeatedElementsSeria = new System.Windows.Forms.Label();
            this.textBoxLongestRepeatedElementsSeria = new System.Windows.Forms.TextBox();
            this.labelSumColumnElementsPositive = new System.Windows.Forms.Label();
            this.dataGridViewSumColumnElementsPositive = new System.Windows.Forms.DataGridView();
            this.labelSumColumnElementsNegative = new System.Windows.Forms.Label();
            this.dataGridViewSumColumnElementsNegative = new System.Windows.Forms.DataGridView();
            this.labelTransposedMatrix = new System.Windows.Forms.Label();
            this.dataGridViewTransposedMatrix = new System.Windows.Forms.DataGridView();
            this.labelMaxElemSumDiag = new System.Windows.Forms.Label();
            this.dataGridViewMaxSumDiagon = new System.Windows.Forms.DataGridView();
            this.textBoxMaxElemSumDiag = new System.Windows.Forms.TextBox();
            this.labelMaxSumDiagon = new System.Windows.Forms.Label();
            this.labelMinElemSumAnotherDiag = new System.Windows.Forms.Label();
            this.textBoxMinElemSumAnotherDiag = new System.Windows.Forms.TextBox();
            this.dataGridViewMinSumAnotherDiag = new System.Windows.Forms.DataGridView();
            this.labelMinSumAnotherDiag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMulWithoutNeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSumColumnElementsPositive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSumColumnElementsNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransposedMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxSumDiagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinSumAnotherDiag)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRowsEnter
            // 
            this.labelRowsEnter.AutoSize = true;
            this.labelRowsEnter.Location = new System.Drawing.Point(23, 28);
            this.labelRowsEnter.Name = "labelRowsEnter";
            this.labelRowsEnter.Size = new System.Drawing.Size(91, 13);
            this.labelRowsEnter.TabIndex = 0;
            this.labelRowsEnter.Text = "Кількість рядків:";
            // 
            // labelCollsEnter
            // 
            this.labelCollsEnter.AutoSize = true;
            this.labelCollsEnter.Location = new System.Drawing.Point(23, 69);
            this.labelCollsEnter.Name = "labelCollsEnter";
            this.labelCollsEnter.Size = new System.Drawing.Size(102, 13);
            this.labelCollsEnter.TabIndex = 1;
            this.labelCollsEnter.Text = "Кількість стовпців:";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.ReadOnly = true;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(457, 186);
            this.dataGridViewMatrix.TabIndex = 2;
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(174, 21);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRows.TabIndex = 3;
            // 
            // numericUpDownColls
            // 
            this.numericUpDownColls.Location = new System.Drawing.Point(174, 62);
            this.numericUpDownColls.Name = "numericUpDownColls";
            this.numericUpDownColls.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownColls.TabIndex = 4;
            // 
            // buttonBuildMatrix
            // 
            this.buttonBuildMatrix.Location = new System.Drawing.Point(361, 28);
            this.buttonBuildMatrix.Name = "buttonBuildMatrix";
            this.buttonBuildMatrix.Size = new System.Drawing.Size(96, 38);
            this.buttonBuildMatrix.TabIndex = 5;
            this.buttonBuildMatrix.Text = "Побудувати!";
            this.buttonBuildMatrix.UseVisualStyleBackColor = true;
            this.buttonBuildMatrix.Click += new System.EventHandler(this.buttonBuildMatrix_Click);
            // 
            // labelPositiveElements
            // 
            this.labelPositiveElements.AutoSize = true;
            this.labelPositiveElements.Location = new System.Drawing.Point(12, 321);
            this.labelPositiveElements.Name = "labelPositiveElements";
            this.labelPositiveElements.Size = new System.Drawing.Size(156, 13);
            this.labelPositiveElements.TabIndex = 6;
            this.labelPositiveElements.Text = "Кількість додатних елементів";
            // 
            // textBoxPositiveElements
            // 
            this.textBoxPositiveElements.Location = new System.Drawing.Point(194, 314);
            this.textBoxPositiveElements.Name = "textBoxPositiveElements";
            this.textBoxPositiveElements.ReadOnly = true;
            this.textBoxPositiveElements.Size = new System.Drawing.Size(100, 20);
            this.textBoxPositiveElements.TabIndex = 7;
            // 
            // labelMaxElem
            // 
            this.labelMaxElem.AutoSize = true;
            this.labelMaxElem.Location = new System.Drawing.Point(12, 357);
            this.labelMaxElem.Name = "labelMaxElem";
            this.labelMaxElem.Size = new System.Drawing.Size(207, 13);
            this.labelMaxElem.TabIndex = 8;
            this.labelMaxElem.Text = "Макс елем, який зустріч декілька разів";
            // 
            // textBoxMaxElem
            // 
            this.textBoxMaxElem.Location = new System.Drawing.Point(309, 354);
            this.textBoxMaxElem.Name = "textBoxMaxElem";
            this.textBoxMaxElem.ReadOnly = true;
            this.textBoxMaxElem.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxElem.TabIndex = 9;
            // 
            // labelCountWithputZeros
            // 
            this.labelCountWithputZeros.AutoSize = true;
            this.labelCountWithputZeros.Location = new System.Drawing.Point(9, 394);
            this.labelCountWithputZeros.Name = "labelCountWithputZeros";
            this.labelCountWithputZeros.Size = new System.Drawing.Size(236, 13);
            this.labelCountWithputZeros.TabIndex = 10;
            this.labelCountWithputZeros.Text = "Кількість рядків, які не містять жодного нуля";
            // 
            // textBoxCountWithputZeros
            // 
            this.textBoxCountWithputZeros.Location = new System.Drawing.Point(309, 391);
            this.textBoxCountWithputZeros.Name = "textBoxCountWithputZeros";
            this.textBoxCountWithputZeros.ReadOnly = true;
            this.textBoxCountWithputZeros.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountWithputZeros.TabIndex = 11;
            // 
            // labelCountColsWithZero
            // 
            this.labelCountColsWithZero.AutoSize = true;
            this.labelCountColsWithZero.Location = new System.Drawing.Point(9, 432);
            this.labelCountColsWithZero.Name = "labelCountColsWithZero";
            this.labelCountColsWithZero.Size = new System.Drawing.Size(247, 13);
            this.labelCountColsWithZero.TabIndex = 12;
            this.labelCountColsWithZero.Text = "Кількість стовпців, які містять хоча б один нуль";
            // 
            // textBoxCountColsWithZero
            // 
            this.textBoxCountColsWithZero.Location = new System.Drawing.Point(309, 425);
            this.textBoxCountColsWithZero.Name = "textBoxCountColsWithZero";
            this.textBoxCountColsWithZero.ReadOnly = true;
            this.textBoxCountColsWithZero.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountColsWithZero.TabIndex = 13;
            // 
            // labelMulWithoutNeg
            // 
            this.labelMulWithoutNeg.AutoSize = true;
            this.labelMulWithoutNeg.Location = new System.Drawing.Point(511, 28);
            this.labelMulWithoutNeg.Name = "labelMulWithoutNeg";
            this.labelMulWithoutNeg.Size = new System.Drawing.Size(354, 13);
            this.labelMulWithoutNeg.TabIndex = 14;
            this.labelMulWithoutNeg.Text = "Добуток елементів в тих рядках, які не містять від’ємних елементів;";
            // 
            // dataGridViewMulWithoutNeg
            // 
            this.dataGridViewMulWithoutNeg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMulWithoutNeg.Location = new System.Drawing.Point(514, 62);
            this.dataGridViewMulWithoutNeg.Name = "dataGridViewMulWithoutNeg";
            this.dataGridViewMulWithoutNeg.ReadOnly = true;
            this.dataGridViewMulWithoutNeg.Size = new System.Drawing.Size(351, 106);
            this.dataGridViewMulWithoutNeg.TabIndex = 15;
            // 
            // labelLongestRepeatedElementsSeria
            // 
            this.labelLongestRepeatedElementsSeria.AutoSize = true;
            this.labelLongestRepeatedElementsSeria.Location = new System.Drawing.Point(9, 462);
            this.labelLongestRepeatedElementsSeria.Name = "labelLongestRepeatedElementsSeria";
            this.labelLongestRepeatedElementsSeria.Size = new System.Drawing.Size(291, 13);
            this.labelLongestRepeatedElementsSeria.TabIndex = 16;
            this.labelLongestRepeatedElementsSeria.Text = "Номер рядка з найдовшою серією однакових елементів";
            // 
            // textBoxLongestRepeatedElementsSeria
            // 
            this.textBoxLongestRepeatedElementsSeria.Location = new System.Drawing.Point(309, 459);
            this.textBoxLongestRepeatedElementsSeria.Name = "textBoxLongestRepeatedElementsSeria";
            this.textBoxLongestRepeatedElementsSeria.ReadOnly = true;
            this.textBoxLongestRepeatedElementsSeria.Size = new System.Drawing.Size(100, 20);
            this.textBoxLongestRepeatedElementsSeria.TabIndex = 17;
            // 
            // labelSumColumnElementsPositive
            // 
            this.labelSumColumnElementsPositive.AutoSize = true;
            this.labelSumColumnElementsPositive.Location = new System.Drawing.Point(511, 197);
            this.labelSumColumnElementsPositive.Name = "labelSumColumnElementsPositive";
            this.labelSumColumnElementsPositive.Size = new System.Drawing.Size(182, 13);
            this.labelSumColumnElementsPositive.TabIndex = 18;
            this.labelSumColumnElementsPositive.Text = "Сума додатних елементів стовпців";
            // 
            // dataGridViewSumColumnElementsPositive
            // 
            this.dataGridViewSumColumnElementsPositive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSumColumnElementsPositive.Location = new System.Drawing.Point(514, 228);
            this.dataGridViewSumColumnElementsPositive.Name = "dataGridViewSumColumnElementsPositive";
            this.dataGridViewSumColumnElementsPositive.ReadOnly = true;
            this.dataGridViewSumColumnElementsPositive.Size = new System.Drawing.Size(351, 106);
            this.dataGridViewSumColumnElementsPositive.TabIndex = 19;
            // 
            // labelSumColumnElementsNegative
            // 
            this.labelSumColumnElementsNegative.AutoSize = true;
            this.labelSumColumnElementsNegative.Location = new System.Drawing.Point(511, 357);
            this.labelSumColumnElementsNegative.Name = "labelSumColumnElementsNegative";
            this.labelSumColumnElementsNegative.Size = new System.Drawing.Size(318, 13);
            this.labelSumColumnElementsNegative.TabIndex = 20;
            this.labelSumColumnElementsNegative.Text = "Сума елементів стовпців, де є хоча б один від\'ємний елемент";
            // 
            // dataGridViewSumColumnElementsNegative
            // 
            this.dataGridViewSumColumnElementsNegative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSumColumnElementsNegative.Location = new System.Drawing.Point(514, 391);
            this.dataGridViewSumColumnElementsNegative.Name = "dataGridViewSumColumnElementsNegative";
            this.dataGridViewSumColumnElementsNegative.ReadOnly = true;
            this.dataGridViewSumColumnElementsNegative.Size = new System.Drawing.Size(351, 106);
            this.dataGridViewSumColumnElementsNegative.TabIndex = 21;
            // 
            // labelTransposedMatrix
            // 
            this.labelTransposedMatrix.AutoSize = true;
            this.labelTransposedMatrix.Location = new System.Drawing.Point(12, 494);
            this.labelTransposedMatrix.Name = "labelTransposedMatrix";
            this.labelTransposedMatrix.Size = new System.Drawing.Size(135, 13);
            this.labelTransposedMatrix.TabIndex = 22;
            this.labelTransposedMatrix.Text = "Транспонована матриця:";
            // 
            // dataGridViewTransposedMatrix
            // 
            this.dataGridViewTransposedMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransposedMatrix.Location = new System.Drawing.Point(12, 527);
            this.dataGridViewTransposedMatrix.Name = "dataGridViewTransposedMatrix";
            this.dataGridViewTransposedMatrix.ReadOnly = true;
            this.dataGridViewTransposedMatrix.Size = new System.Drawing.Size(457, 186);
            this.dataGridViewTransposedMatrix.TabIndex = 23;
            // 
            // labelMaxElemSumDiag
            // 
            this.labelMaxElemSumDiag.AutoSize = true;
            this.labelMaxElemSumDiag.Location = new System.Drawing.Point(511, 527);
            this.labelMaxElemSumDiag.Name = "labelMaxElemSumDiag";
            this.labelMaxElemSumDiag.Size = new System.Drawing.Size(393, 13);
            this.labelMaxElemSumDiag.TabIndex = 24;
            this.labelMaxElemSumDiag.Text = "Максимум серед сум елементів діагоналей, паралельних головній діагоналі";
            // 
            // dataGridViewMaxSumDiagon
            // 
            this.dataGridViewMaxSumDiagon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaxSumDiagon.Location = new System.Drawing.Point(514, 607);
            this.dataGridViewMaxSumDiagon.Name = "dataGridViewMaxSumDiagon";
            this.dataGridViewMaxSumDiagon.ReadOnly = true;
            this.dataGridViewMaxSumDiagon.Size = new System.Drawing.Size(351, 106);
            this.dataGridViewMaxSumDiagon.TabIndex = 25;
            // 
            // textBoxMaxElemSumDiag
            // 
            this.textBoxMaxElemSumDiag.Location = new System.Drawing.Point(514, 555);
            this.textBoxMaxElemSumDiag.Name = "textBoxMaxElemSumDiag";
            this.textBoxMaxElemSumDiag.ReadOnly = true;
            this.textBoxMaxElemSumDiag.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxElemSumDiag.TabIndex = 26;
            // 
            // labelMaxSumDiagon
            // 
            this.labelMaxSumDiagon.AutoSize = true;
            this.labelMaxSumDiagon.Location = new System.Drawing.Point(774, 581);
            this.labelMaxSumDiagon.Name = "labelMaxSumDiagon";
            this.labelMaxSumDiagon.Size = new System.Drawing.Size(91, 13);
            this.labelMaxSumDiagon.TabIndex = 27;
            this.labelMaxSumDiagon.Text = "Суми діагоналей";
            // 
            // labelMinElemSumAnotherDiag
            // 
            this.labelMinElemSumAnotherDiag.AutoSize = true;
            this.labelMinElemSumAnotherDiag.Location = new System.Drawing.Point(75, 745);
            this.labelMinElemSumAnotherDiag.Name = "labelMinElemSumAnotherDiag";
            this.labelMinElemSumAnotherDiag.Size = new System.Drawing.Size(394, 13);
            this.labelMinElemSumAnotherDiag.TabIndex = 28;
            this.labelMinElemSumAnotherDiag.Text = "Мінімум серед сум модулів елементів діагоналей, паралел побічній діагоналі";
            // 
            // textBoxMinElemSumAnotherDiag
            // 
            this.textBoxMinElemSumAnotherDiag.Location = new System.Drawing.Point(514, 738);
            this.textBoxMinElemSumAnotherDiag.Name = "textBoxMinElemSumAnotherDiag";
            this.textBoxMinElemSumAnotherDiag.ReadOnly = true;
            this.textBoxMinElemSumAnotherDiag.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinElemSumAnotherDiag.TabIndex = 29;
            // 
            // dataGridViewMinSumAnotherDiag
            // 
            this.dataGridViewMinSumAnotherDiag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMinSumAnotherDiag.Location = new System.Drawing.Point(342, 775);
            this.dataGridViewMinSumAnotherDiag.Name = "dataGridViewMinSumAnotherDiag";
            this.dataGridViewMinSumAnotherDiag.ReadOnly = true;
            this.dataGridViewMinSumAnotherDiag.Size = new System.Drawing.Size(351, 106);
            this.dataGridViewMinSumAnotherDiag.TabIndex = 30;
            // 
            // labelMinSumAnotherDiag
            // 
            this.labelMinSumAnotherDiag.AutoSize = true;
            this.labelMinSumAnotherDiag.Location = new System.Drawing.Point(90, 775);
            this.labelMinSumAnotherDiag.Name = "labelMinSumAnotherDiag";
            this.labelMinSumAnotherDiag.Size = new System.Drawing.Size(226, 13);
            this.labelMinSumAnotherDiag.TabIndex = 31;
            this.labelMinSumAnotherDiag.Text = "Суми діагоналей паралел побічній діагоналі";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 893);
            this.Controls.Add(this.labelMinSumAnotherDiag);
            this.Controls.Add(this.dataGridViewMinSumAnotherDiag);
            this.Controls.Add(this.textBoxMinElemSumAnotherDiag);
            this.Controls.Add(this.labelMinElemSumAnotherDiag);
            this.Controls.Add(this.labelMaxSumDiagon);
            this.Controls.Add(this.textBoxMaxElemSumDiag);
            this.Controls.Add(this.dataGridViewMaxSumDiagon);
            this.Controls.Add(this.labelMaxElemSumDiag);
            this.Controls.Add(this.dataGridViewTransposedMatrix);
            this.Controls.Add(this.labelTransposedMatrix);
            this.Controls.Add(this.dataGridViewSumColumnElementsNegative);
            this.Controls.Add(this.labelSumColumnElementsNegative);
            this.Controls.Add(this.dataGridViewSumColumnElementsPositive);
            this.Controls.Add(this.labelSumColumnElementsPositive);
            this.Controls.Add(this.textBoxLongestRepeatedElementsSeria);
            this.Controls.Add(this.labelLongestRepeatedElementsSeria);
            this.Controls.Add(this.dataGridViewMulWithoutNeg);
            this.Controls.Add(this.labelMulWithoutNeg);
            this.Controls.Add(this.textBoxCountColsWithZero);
            this.Controls.Add(this.labelCountColsWithZero);
            this.Controls.Add(this.textBoxCountWithputZeros);
            this.Controls.Add(this.labelCountWithputZeros);
            this.Controls.Add(this.textBoxMaxElem);
            this.Controls.Add(this.labelMaxElem);
            this.Controls.Add(this.textBoxPositiveElements);
            this.Controls.Add(this.labelPositiveElements);
            this.Controls.Add(this.buttonBuildMatrix);
            this.Controls.Add(this.numericUpDownColls);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.labelCollsEnter);
            this.Controls.Add(this.labelRowsEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Olena Machushnyk";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMulWithoutNeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSumColumnElementsPositive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSumColumnElementsNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransposedMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxSumDiagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinSumAnotherDiag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRowsEnter;
        private System.Windows.Forms.Label labelCollsEnter;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownColls;
        private System.Windows.Forms.Button buttonBuildMatrix;
        private System.Windows.Forms.Label labelPositiveElements;
        private System.Windows.Forms.TextBox textBoxPositiveElements;
        private System.Windows.Forms.Label labelMaxElem;
        private System.Windows.Forms.TextBox textBoxMaxElem;
        private System.Windows.Forms.Label labelCountWithputZeros;
        private System.Windows.Forms.TextBox textBoxCountWithputZeros;
        private System.Windows.Forms.Label labelCountColsWithZero;
        private System.Windows.Forms.TextBox textBoxCountColsWithZero;
        private System.Windows.Forms.Label labelMulWithoutNeg;
        private System.Windows.Forms.DataGridView dataGridViewMulWithoutNeg;
        private System.Windows.Forms.Label labelLongestRepeatedElementsSeria;
        private System.Windows.Forms.TextBox textBoxLongestRepeatedElementsSeria;
        private System.Windows.Forms.Label labelSumColumnElementsPositive;
        private System.Windows.Forms.DataGridView dataGridViewSumColumnElementsPositive;
        private System.Windows.Forms.Label labelSumColumnElementsNegative;
        private System.Windows.Forms.DataGridView dataGridViewSumColumnElementsNegative;
        private System.Windows.Forms.Label labelTransposedMatrix;
        private System.Windows.Forms.DataGridView dataGridViewTransposedMatrix;
        private System.Windows.Forms.Label labelMaxElemSumDiag;
        private System.Windows.Forms.DataGridView dataGridViewMaxSumDiagon;
        private System.Windows.Forms.TextBox textBoxMaxElemSumDiag;
        private System.Windows.Forms.Label labelMaxSumDiagon;
        private System.Windows.Forms.Label labelMinElemSumAnotherDiag;
        private System.Windows.Forms.TextBox textBoxMinElemSumAnotherDiag;
        private System.Windows.Forms.DataGridView dataGridViewMinSumAnotherDiag;
        private System.Windows.Forms.Label labelMinSumAnotherDiag;
    }
}

