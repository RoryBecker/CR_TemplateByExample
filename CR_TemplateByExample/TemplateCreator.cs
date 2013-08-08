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
    public static class TemplateCreator
    {
        public static void CreateTemplate(string Name, string Expansion, string CategoryName, ContextPickerData Context)
        {
            Template Template = GetOrCreateTemplateByNameAndCat(Name, CategoryName, CodeRush.Language.Active);
            TemplateData Data = new TemplateData();
            Data.Expansion = Expansion;
            Data.SetContext(Context);
            switch (Template.Items.Count)
            {
                case 0:
                    Template.Items.Add(Data);
                    break;
                case 1:
                    DialogResult Replace = MessageBox.Show("This Template already exists. Would you like to replace the old Template?", "Template already exists", MessageBoxButtons.YesNoCancel);
                    switch (Replace)
                    {
                        case DialogResult.Yes:
                            //Replace Existing Template Variations
                            Template.Items.Clear();
                            Template.Items.Add(Data);
                            break;
                        case DialogResult.No:
                            // Add this variation to those already existing.
                            Template.Items.Add(Data);
                            break;
                        default:
                            return; // Cancel
                    }
                    break;
                default:
                    // Many alternatives
                    MessageBox.Show("Multiple Template expansions found. Aborting.");
                    return;
            }
            CodeRush.Templates.Save();
        }
        private static Template GetOrCreateTemplateByNameAndCat(string TemplateName, string CategoryName, string Language)
        {
            TemplateCategory QTC = CodeRush.Templates.FindCategory(CategoryName, Language);
            if (QTC == null)
                QTC = CodeRush.Templates.AddCategory(CategoryName, "", Language);
            Template Template = CodeRush.Templates.FindTemplate(TemplateName, CategoryName, Language);
            if (Template == null)
                Template = CodeRush.Templates.AddTemplate(TemplateName, CategoryName, Language);
            return Template;
        }
        public static string CreateTemplate(string SourceString, string[] FieldList, string CaretItem = "")
        {
            foreach (string Field in FieldList)
            {
                string TrimmedField = Field.Trim();
                // Replace All instances with TypeLink
                SourceString = ReplaceAllNotQuoted(SourceString, TrimmedField, LinkOfText(TrimmedField), "TypeLink«(", ")»");
                // Wrap First occurence with Field
                SourceString = ReplaceFirstOnly(SourceString, LinkOfText(TrimmedField), FieldOfText(LinkOfText(TrimmedField)), "«FieldStart»", "«FieldEnd»");

            }
            // Wrap Nomination with Caret-BlockAnchor
            SourceString = ReplaceFirstOnly(SourceString, FieldOfText(LinkOfText(CaretItem)), CaretWrappedText(FieldOfText(LinkOfText(CaretItem))), "«Caret»", "«BlockAnchor»");
            return SourceString;
        }
        private static string ReplaceAllNotQuoted(string Text, string SearchFor, string ReplaceWith, string StartQuote, string EndQuote)
        {
            string Pattern = GetReplacePatternFromSearchData(SearchFor, StartQuote, EndQuote);
            // Return Regex.Replace(Text, Pattern, ReplaceWith)
            Regex RegexObj = new Regex(Pattern);
            return RegexObj.Replace(Text, ReplaceWith);
        }
        private static string GetReplacePatternFromSearchData(string SearchFor, string StartQuote, string EndQuote)
        {
            StartQuote = Regex.Escape(StartQuote);
            EndQuote = Regex.Escape(EndQuote);
            SearchFor = Regex.Escape(SearchFor);
            return String.Format("(?!{1}\\w*){0}(?!\\w*{2})", SearchFor, StartQuote, EndQuote);
        }
        private static string ReplaceFirstOnly(string Search, string SearchFor, string ReplaceWith, string StartQuote, string EndQuote)
        {
            string Pattern = GetReplacePatternFromSearchData(SearchFor, StartQuote, EndQuote);
            Match RegexMatch = Regex.Match(Search, Pattern);
            if (RegexMatch.Captures.Count == 0)
                return Search;
            int Pos = RegexMatch.Captures[0].Index;
            return Search.Substring(0, Pos) + ReplaceWith + Search.Substring(Pos + SearchFor.Length);
        }

        private static string CaretWrappedText(string Text)
        {
            return string.Format("«Caret»{0}«BlockAnchor»", Text);
        }
        private static string FieldOfText(string Text)
        {
            return String.Format("«FieldStart»{0}«FieldEnd»", Text);
        }
        private static string LinkOfText(string Text)
        {
            return String.Format("«TypeLink({0})»", Text);
        }

    }
}
