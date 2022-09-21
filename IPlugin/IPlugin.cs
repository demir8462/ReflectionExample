using System.Windows.Forms;
namespace IPlugin
{
    public interface IPLUGIN
    {
        
        public ClassProp PROP { get; set; }
        string Name { get; set; }
        string Desc { get; set; }
        void Run();
    }
    public class ClassProp
    {
        public Form winform;
        public delegate void writeConsole(string text);
        public writeConsole func;
        Color getBackColor()
        {
            return winform.BackColor;
        }
        void setBackColor(Color color)
        {
            winform.BackColor = color; 
        }
        string getTitle()
        {
            return winform.Text;
        }
        void setTitle(string text)
        {
            winform.Text = text;
        }
    }
}