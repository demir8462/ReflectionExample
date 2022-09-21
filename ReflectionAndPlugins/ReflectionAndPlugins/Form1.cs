using System.Reflection;
namespace ReflectionAndPlugins
{

    public partial class Form1 : Form
    {
        delegate void rundel();
        delegate void DaddToConsole(string txt);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

           foreach (Type item in asm.GetTypes())
            {
                if(item.Name == "Human")
                {
                    object ahmet = Activator.CreateInstance(item);
                    ((Human)ahmet).func = addToConsole; // WORKS
                    item.GetField("name").SetValue(ahmet, "ahmet");
                    object[] param = { "Ali" };
                    item.GetMethod("greet").Invoke(ahmet, param);
                }
            }
        }
        void addToConsole(string txt)
        {
            textBox1.AppendText(txt);
            textBox1.AppendText(Environment.NewLine);
        }
    }
    public class Human
    {
        public string name;
        public delegate void addToConsole(string txt);
        public addToConsole func { get; set; }
        public void greet(string who)
        {
            func("Hi "+who+", im "+name+"!");
        }

    }

}