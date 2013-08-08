using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;

namespace CR_TemplateByExample
{
    public partial class PlugIn1 : StandardPlugIn
    {
        // DXCore-generated code...
        #region InitializePlugIn
        public override void InitializePlugIn()
        {
            base.InitializePlugIn();
            registerCreateTempTemplate();
            registerExecuteTempTemplate();
        }
        #endregion
        #region FinalizePlugIn
        public override void FinalizePlugIn()
        {
            //
            // TODO: Add your finalization code here.
            //

            base.FinalizePlugIn();
        }
        #endregion

        public void registerCreateTempTemplate()
        {
            DevExpress.CodeRush.Core.Action CreateTempTemplate = new DevExpress.CodeRush.Core.Action(components);
            ((System.ComponentModel.ISupportInitialize)(CreateTempTemplate)).BeginInit();
            CreateTempTemplate.ActionName = "CreateTempTemplate";
            CreateTempTemplate.ButtonText = "CreateTempTemplate"; // Used if button is placed on a menu.
            CreateTempTemplate.RegisterInCR = true;
            CreateTempTemplate.Execute += CreateTempTemplate_Execute;
            ((System.ComponentModel.ISupportInitialize)(CreateTempTemplate)).EndInit();
        }
        private void CreateTempTemplate_Execute(ExecuteEventArgs ea)
        {
            TemplateBuilder.CreateQuickTemplate(CodeRush.Selection.Text);
        }
        public void registerExecuteTempTemplate()
        {
            DevExpress.CodeRush.Core.Action ExecuteTempTemplate = new DevExpress.CodeRush.Core.Action(components);
            ((System.ComponentModel.ISupportInitialize)(ExecuteTempTemplate)).BeginInit();
            ExecuteTempTemplate.ActionName = "ExecuteTempTemplate";
            ExecuteTempTemplate.ButtonText = "ExecuteTempTemplate"; // Used if button is placed on a menu.
            ExecuteTempTemplate.RegisterInCR = true;
            ExecuteTempTemplate.Execute += ExecuteTempTemplate_Execute;
            ((System.ComponentModel.ISupportInitialize)(ExecuteTempTemplate)).EndInit();
        }
        private void ExecuteTempTemplate_Execute(ExecuteEventArgs ea)
        {
            CodeRush.Templates.ExpandTemplate("#TempTemplate#");
        }
    }
}