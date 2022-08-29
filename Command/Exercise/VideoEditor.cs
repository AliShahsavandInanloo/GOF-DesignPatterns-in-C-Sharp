namespace DesignPatterns.Command.Exercise
{
    public class VideoEditor
    {
        public string Text { get; set; }

        public float Contrast { get; set; } = 0.5f;

        public void RemoveText()
        {
            this.Text = "";
        }

        public override string ToString()
        {
            return $"VideoEditor contrast={this.Contrast}," +
                   $"text= {this.Text}";
        }
    }
}