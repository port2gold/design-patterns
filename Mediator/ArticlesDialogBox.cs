namespace design_patterns.Mediator
{
    public class ArticlesDialogBox 
    {
        private ListBox articlesListBox = new ListBox();
        private TextBox titleTextBox = new TextBox();
        private Button saveButton = new Button();

        public ArticlesDialogBox()
        {
            articlesListBox.ArticleSelectedEvent += ArticleSelected;
            titleTextBox.TitleChangedEvent += TitleChanged;
        }

        public void SimulateUserInteraction()
        {

            articlesListBox.SetSelection("Article 1");
            titleTextBox.SetContent("");
            //titleTextBox.SetContent("Article 2");
            Console.WriteLine($"TextBox: {titleTextBox.GetContent()}");
            Console.WriteLine($"Button: {saveButton.IsEnabled()}");
        }

        //public override void Changed(UIControl control)
        //{
        //    if(control ==  articlesListBox)
        //    {
        //        ArticleSelected();
        //    }
        //    else if(control == titleTextBox)
        //    {
        //        TitleChanged();
        //    }
        //}

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
