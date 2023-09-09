﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticlesDialogBox() : base()
        {
            articlesListBox = new ListBox(this);
            titleTextBox = new TextBox(this);
            saveButton = new Button(this);
        }

        public void SimulateUserInteraction()
        {
            articlesListBox.SetSelection("Article 1");
            titleTextBox.SetContent("");
            titleTextBox.SetContent("Article 2");
            Console.WriteLine($"TextBox: {titleTextBox.GetContent()}");
            Console.WriteLine($"Button: {saveButton.IsEnabled()}");
        }

        public override void Changed(UIControl control)
        {
            if(control ==  articlesListBox)
            {
                ArticleSelected();
            }
            else if(control == titleTextBox)
            {
                TitleChanged();
            }
        }

        private void TitleChanged()
        {
            var content = titleTextBox.GetContent();
            var isEmpty = string.IsNullOrEmpty(content);
            saveButton.SetEnabled(!isEmpty);
        }

        private void ArticleSelected()
        {
            titleTextBox.SetContent(articlesListBox.GetSelection());
            saveButton.SetEnabled(true);
        }
    }
}
