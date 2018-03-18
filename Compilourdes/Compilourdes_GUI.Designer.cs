namespace Compilourdes
{
    partial class Compilourdes_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compilourdes_GUI));
            this.tblLexeme = new System.Windows.Forms.DataGridView();
            this.tblErrors = new System.Windows.Forms.DataGridView();
            this.err_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.err_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.err_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRun = new System.Windows.Forms.Button();
            this.gvSyntaxError = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSyntax = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSemanticError = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCode = new Ionic.WinForms.RichTextBoxEx();
            this.lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attribu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblLexeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSyntaxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSyntax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSemanticError)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLexeme
            // 
            this.tblLexeme.AllowUserToAddRows = false;
            this.tblLexeme.AllowUserToDeleteRows = false;
            this.tblLexeme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tblLexeme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblLexeme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblLexeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLexeme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lexeme,
            this.token,
            this.lineno,
            this.attribu});
            this.tblLexeme.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblLexeme.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblLexeme.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.tblLexeme, "tblLexeme");
            this.tblLexeme.Name = "tblLexeme";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblLexeme.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.tblLexeme.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblLexeme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblLexeme_CellContentClick);
            // 
            // tblErrors
            // 
            this.tblErrors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblErrors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tblErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.err_code,
            this.err_desc,
            this.err_line});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblErrors.DefaultCellStyle = dataGridViewCellStyle6;
            this.tblErrors.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.tblErrors, "tblErrors");
            this.tblErrors.Name = "tblErrors";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblErrors.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tblErrors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblErrors_CellContentClick);
            // 
            // err_code
            // 
            resources.ApplyResources(this.err_code, "err_code");
            this.err_code.Name = "err_code";
            this.err_code.ReadOnly = true;
            // 
            // err_desc
            // 
            resources.ApplyResources(this.err_desc, "err_desc");
            this.err_desc.Name = "err_desc";
            this.err_desc.ReadOnly = true;
            // 
            // err_line
            // 
            resources.ApplyResources(this.err_line, "err_line");
            this.err_line.Name = "err_line";
            this.err_line.ReadOnly = true;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.btnRun, "btnRun");
            this.btnRun.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnRun.Name = "btnRun";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // gvSyntaxError
            // 
            this.gvSyntaxError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSyntaxError.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSyntaxError.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.gvSyntaxError, "gvSyntaxError");
            this.gvSyntaxError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.errors,
            this.linenum});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSyntaxError.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvSyntaxError.EnableHeadersVisualStyles = false;
            this.gvSyntaxError.Name = "gvSyntaxError";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSyntaxError.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvSyntaxError.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSyntaxError_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 48.73096F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // errors
            // 
            this.errors.FillWeight = 195.1686F;
            resources.ApplyResources(this.errors, "errors");
            this.errors.Name = "errors";
            this.errors.ReadOnly = true;
            // 
            // linenum
            // 
            this.linenum.FillWeight = 56.10039F;
            resources.ApplyResources(this.linenum, "linenum");
            this.linenum.Name = "linenum";
            // 
            // gvSyntax
            // 
            this.gvSyntax.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSyntax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gvSyntax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSyntax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Productions,
            this.point,
            this.Sets});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSyntax.DefaultCellStyle = dataGridViewCellStyle12;
            this.gvSyntax.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.gvSyntax, "gvSyntax");
            this.gvSyntax.Name = "gvSyntax";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSyntax.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Productions
            // 
            resources.ApplyResources(this.Productions, "Productions");
            this.Productions.Name = "Productions";
            this.Productions.ReadOnly = true;
            // 
            // point
            // 
            resources.ApplyResources(this.point, "point");
            this.point.Name = "point";
            this.point.ReadOnly = true;
            // 
            // Sets
            // 
            resources.ApplyResources(this.Sets, "Sets");
            this.Sets.Name = "Sets";
            this.Sets.ReadOnly = true;
            // 
            // gvSemanticError
            // 
            this.gvSemanticError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSemanticError.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSemanticError.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.gvSemanticError, "gvSemanticError");
            this.gvSemanticError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSemanticError.DefaultCellStyle = dataGridViewCellStyle15;
            this.gvSemanticError.EnableHeadersVisualStyles = false;
            this.gvSemanticError.Name = "gvSemanticError";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSemanticError.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 47.24342F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 205.5837F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 47.1728F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.SkyBlue;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.SkyBlue;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.SkyBlue;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.SkyBlue;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtCode
            // 
            this.txtCode.AcceptsTab = true;
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.DetectUrls = false;
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.Name = "txtCode";
            this.txtCode.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.txtCode.NumberBackground1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.NumberBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.NumberBorder = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCode.NumberBorderThickness = 1F;
            this.txtCode.NumberColor = System.Drawing.Color.SkyBlue;
            this.txtCode.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.NumberLeadingZeroes = false;
            this.txtCode.NumberLineCounting = Ionic.WinForms.RichTextBoxEx.LineCounting.CRLF;
            this.txtCode.NumberPadding = 2;
            this.txtCode.ShowLineNumbers = true;
            // 
            // lexeme
            // 
            resources.ApplyResources(this.lexeme, "lexeme");
            this.lexeme.Name = "lexeme";
            this.lexeme.ReadOnly = true;
            // 
            // token
            // 
            resources.ApplyResources(this.token, "token");
            this.token.Name = "token";
            this.token.ReadOnly = true;
            // 
            // lineno
            // 
            resources.ApplyResources(this.lineno, "lineno");
            this.lineno.Name = "lineno";
            this.lineno.ReadOnly = true;
            // 
            // attribu
            // 
            resources.ApplyResources(this.attribu, "attribu");
            this.attribu.Name = "attribu";
            this.attribu.ReadOnly = true;
            // 
            // Compilourdes_GUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvSemanticError);
            this.Controls.Add(this.gvSyntax);
            this.Controls.Add(this.gvSyntaxError);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tblErrors);
            this.Controls.Add(this.tblLexeme);
            this.Name = "Compilourdes_GUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Compilourdes_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLexeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSyntaxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSyntax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSemanticError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tblErrors;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView tblLexeme;
        private Ionic.WinForms.RichTextBoxEx txtCode;
        private System.Windows.Forms.DataGridView gvSyntax;
        private System.Windows.Forms.DataGridView gvSyntaxError;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn errors;
        private System.Windows.Forms.DataGridViewTextBoxColumn linenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn err_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn err_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn err_line;
        private System.Windows.Forms.DataGridView gvSemanticError;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productions;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn token;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineno;
        private System.Windows.Forms.DataGridViewTextBoxColumn attribu;
    }
}

