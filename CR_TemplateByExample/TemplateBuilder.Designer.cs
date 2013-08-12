namespace CR_TemplateByExample
{
    partial class TemplateBuilder
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.lblHelp3 = new System.Windows.Forms.Label();
            this.lblHelp2 = new System.Windows.Forms.Label();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.ContextPicker1 = new DevExpress.CodeRush.UserControls.ContextPicker();
            this.txtFields = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.lblHelp1 = new System.Windows.Forms.Label();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Location = new System.Drawing.Point(12, 165);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(573, 201);
            this.TabControl1.TabIndex = 20;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.lblHelp3);
            this.TabPage1.Controls.Add(this.lblHelp2);
            this.TabPage1.Controls.Add(this.txtSelection);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(565, 175);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Base Text";
            // 
            // lblHelp3
            // 
            this.lblHelp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHelp3.Location = new System.Drawing.Point(321, 13);
            this.lblHelp3.Name = "lblHelp3";
            this.lblHelp3.Size = new System.Drawing.Size(219, 125);
            this.lblHelp3.TabIndex = 25;
            this.lblHelp3.Text = "Preview\r\n\r\nDefinition:\r\nCalculated from BaseText and Substitutions\r\n\r\nExample:\r\nT" +
    "he «Field(Quick)» «Field(Brown)» Fox";
            // 
            // lblHelp2
            // 
            this.lblHelp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHelp2.Location = new System.Drawing.Point(10, 13);
            this.lblHelp2.Name = "lblHelp2";
            this.lblHelp2.Size = new System.Drawing.Size(199, 125);
            this.lblHelp2.TabIndex = 24;
            this.lblHelp2.Text = "BaseText \r\n\r\nDefinition:\r\nProvided by selection prior to activation.\r\n\r\nExample:\r" +
    "\nThe Quick Brown Fox";
            // 
            // txtSelection
            // 
            this.txtSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSelection.HideSelection = false;
            this.txtSelection.Location = new System.Drawing.Point(0, 0);
            this.txtSelection.Multiline = true;
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSelection.Size = new System.Drawing.Size(565, 175);
            this.txtSelection.TabIndex = 2;
            this.txtSelection.WordWrap = false;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.txtTemplate);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(565, 175);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Preview";
            // 
            // txtTemplate
            // 
            this.txtTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplate.Location = new System.Drawing.Point(0, 0);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ReadOnly = true;
            this.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTemplate.Size = new System.Drawing.Size(565, 175);
            this.txtTemplate.TabIndex = 8;
            this.txtTemplate.TabStop = false;
            this.txtTemplate.WordWrap = false;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.ContextPicker1);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(565, 175);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Context";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // ContextPicker1
            // 
            this.ContextPicker1.HintDisplayTime = 6000;
            this.ContextPicker1.HintWindowWidth = 200;
            this.ContextPicker1.LegendBackground = System.Drawing.Color.White;
            this.ContextPicker1.LegendFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.ContextPicker1.Location = new System.Drawing.Point(6, 6);
            this.ContextPicker1.Name = "ContextPicker1";
            this.ContextPicker1.RootContext = "";
            this.ContextPicker1.ShowHint = true;
            this.ContextPicker1.ShowLegend = true;
            this.ContextPicker1.Size = new System.Drawing.Size(447, 163);
            this.ContextPicker1.TabIndex = 23;
            // 
            // txtFields
            // 
            this.txtFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFields.Location = new System.Drawing.Point(16, 25);
            this.txtFields.Multiline = true;
            this.txtFields.Name = "txtFields";
            this.txtFields.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFields.Size = new System.Drawing.Size(565, 134);
            this.txtFields.TabIndex = 16;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Location = new System.Drawing.Point(510, 368);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 18;
            this.cmdCancel.Text = "C&ancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOk.Location = new System.Drawing.Point(429, 368);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 17;
            this.cmdOk.Text = "&Ok";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // lblHelp1
            // 
            this.lblHelp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHelp1.Location = new System.Drawing.Point(26, 33);
            this.lblHelp1.Name = "lblHelp1";
            this.lblHelp1.Size = new System.Drawing.Size(530, 116);
            this.lblHelp1.TabIndex = 23;
            this.lblHelp1.Text = "Substitutions:\r\n\r\nDefinition:\r\n A Newline separated list of strings used to infer" +
    " the location of fields and links within the final template.\r\n\r\nExample:\r\nQuick\r" +
    "\nBrown\r\n";
            // 
            // cmdHelp
            // 
            this.cmdHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHelp.Location = new System.Drawing.Point(12, 368);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(116, 23);
            this.cmdHelp.TabIndex = 24;
            this.cmdHelp.Text = "Toggle Help";
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Substitutions";
            // 
            // TemplateBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.lblHelp1);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.txtFields);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Name = "TemplateBuilder";
            this.Text = "Substitutions";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TextBox txtSelection;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox txtTemplate;
        internal System.Windows.Forms.TextBox txtFields;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Label lblHelp3;
        private System.Windows.Forms.Label lblHelp2;
        private System.Windows.Forms.TabPage TabPage3;
        private DevExpress.CodeRush.UserControls.ContextPicker ContextPicker1;
        private System.Windows.Forms.Label lblHelp1;
        private System.Windows.Forms.Button cmdHelp;
        private System.Windows.Forms.Label label1;

    }
}