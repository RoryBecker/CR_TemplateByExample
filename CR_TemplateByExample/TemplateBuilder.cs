using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CR_TemplateByExample
{
    public partial class TemplateBuilder : Form
    {

        #region Start Here
        public static void CreateQuickTemplate(string BaseText)
        {
            TemplateBuilder TheForm = new TemplateBuilder();
            TheForm.txtSelection.Text = BaseText;
            //CodeRush.Context.PopulateContextPicker(TheForm.ContextPicker1, CodeRush.Language.Active);
            TheForm.ShowDialog();
        }
        #endregion
        #region Construction

        private bool mHelp = false;
        private bool mLoaded = false;
        private TemplateBuilder()
        {
            InitializeComponent();
            mLoaded = true;
        }
        #endregion
        #region UI
        public void cmdAddAsField_Click(object sender, EventArgs e)
        {
            if (txtSelection.SelectedText.IndexOf(Environment.NewLine) > -1)
                return;

            if (txtSelection.SelectedText != String.Empty)
                if (!FieldListContains(txtSelection.SelectedText))
                    AddField(txtSelection.SelectedText);
        }
        private void cmdOk_Click(object sender, EventArgs e)
        {
            ValidateAndQuit();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mLoaded)
                UpdatePreview();
        }
        #endregion

        private void AddField(string Field)
        {
            txtFields.Text = txtFields.Text.Trim();
            if (txtFields.Text == String.Empty)
                txtFields.Text = Field;
            else
                txtFields.Text = txtFields.Text.Trim() + Environment.NewLine + Field;

        }
        private bool FieldListContains(string SearchFor)
        {
            if (txtFields.Text.Trim() == string.Empty)
                return false;
            for (int i = 0; i < txtFields.Lines.GetLength(0); i++)
            {
                if (txtFields.Lines[i].Trim() == SearchFor)
                    return true;
            }

            return false;
        }

        public string GetPrimaryField
        {
            get
            {
                if (txtFields.Text == string.Empty)
                    return string.Empty;
                return txtFields.Lines[0].Trim();
            }
        }

        private bool FormIsValid(string ErrorMessage)
        {
            //if (txtTemplateName.Text.Trim() == string.Empty)
            //{
            //    ErrorMessage = "Template has no Name";
            //    txtTemplateName.Focus();
            //    return false;
            //}
            if (txtSelection.Text.Trim() == string.Empty)
            {
                ErrorMessage = "Template text is empty.";
                txtSelection.Focus();
                return false;
            }
            return true;
        }
        private void ValidateAndQuit()
        {
            ValidateAndProcess();
            TemplateCreator.CreateTemplate("#TempTemplate#",
                            txtTemplate.Text,
                            "QuickTemplates",
                            ContextPicker1.GetData());
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void ValidateAndProcess()
        {
            // Check Form Valid
            string ErrorMessage = String.Empty;
            if (!FormIsValid(ErrorMessage))
            {
                MessageBox.Show(ErrorMessage);
                return;
            }
            UpdatePreview();
        }
        private void UpdatePreview()
        {
            txtTemplate.Text =
                TemplateCreator.CreateTemplate(txtSelection.Text,
                                                   txtFields.Lines,
                                                   GetPrimaryField);
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            mHelp = !mHelp;
            lblHelp1.Visible = mHelp;
            lblHelp2.Visible = mHelp;
            lblHelp3.Visible = mHelp;
        }
    }
}