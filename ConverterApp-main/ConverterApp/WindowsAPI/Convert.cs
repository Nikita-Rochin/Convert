using PhysicValuesLib;

namespace WindowsAPI
{
    public partial class Convert : Form
    {
        private ConverterManager _manager;
        public Convert()
        {
            InitializeComponent();

            _manager = new ConverterManager();
        }

        private void Convert1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(_manager.GetPhysicValuesList().ToArray());
            listBox1.SelectedIndex = 0;
            listBox3.SelectedIndex = 0;
            listBox2.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Items.AddRange(_manager.GetMeasureList(listBox1.SelectedItem.ToString()).ToArray());
            listBox3.Items.AddRange(_manager.GetMeasureList(listBox1.SelectedItem.ToString()).ToArray());
            listBox3.SelectedIndex = 0;
            listBox2.SelectedIndex = 0;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            double value = System.Convert.ToDouble(textBox1.Text);
            string physicValue = listBox1.SelectedItem.ToString();
            string from = listBox2.SelectedItem.ToString(); 
            string to = listBox3.SelectedItem.ToString();
            double result = _manager.GetConvertedValue(physicValue, value, from, to);
            textBox2.Text = result.ToString();
        }
    }
}