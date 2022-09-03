using System;

namespace DesignPatterns.Mediator
{
    public class ArticleDialogBox : DialogBox
    {
        private readonly ListBox _articleListBox;
        private readonly TextBox _titleTextBox;
        private readonly Button  _saveButton;

        public ArticleDialogBox()
        {
            this._articleListBox = new ListBox(this);
            this._titleTextBox   = new TextBox(this);
            this._saveButton     = new Button(this);
        }

        public void SimulateUserInteraction()
        {
            this._articleListBox.Selection = "Article 1";

            Console.WriteLine("TextBox: " + this._titleTextBox.Content);
            Console.WriteLine("Button: "  + this._saveButton.Enabled);
        }

        public override void Changed(UiControl control)
        {
            if (control == this._articleListBox)
                ArticleSelected();
            else if (control == this._titleTextBox)
                TitleChanged();
        }

        private void TitleChanged()
        {
            var content = this._titleTextBox.Content;
            var isEmpty = string.IsNullOrEmpty(content);

            this._saveButton.Enabled = !isEmpty;
        }

        private void ArticleSelected()
        {
            this._titleTextBox.Content = this._articleListBox.Selection;
            this._saveButton.Enabled   = true;
        }
    }
}