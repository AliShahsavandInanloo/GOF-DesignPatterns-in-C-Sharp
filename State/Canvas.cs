namespace DesignPatterns.State
{
    internal class Canvas
    {
        public ITool CurrentTool { get; set; }

        public void MouseDown()
        {
            this.CurrentTool.MouseDown();
        }

        public void MouseUp()
        {
            this.CurrentTool.MouseUp();
        }
    }
}