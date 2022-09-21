using System.Drawing;
namespace PluginM
{
    interface PluginM
    {
        private FormProps prop;
        string Name { get; set; }
        string Description { get; set; }
        FormProps Prop { get; set; }

        public void Run();
        public Color getFormBackColor();
    }
    public class FormProps
    {
        Form f;
        public void setColor(Color c)
        {

        }
        public Color getColor()
        {
            return 
        }
    }
}