namespace wf_class_7_2_24_TSK_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
           if(listBox1.SelectedIndex == 0)
           {
                listView1.Items.Clear();
                ListViewItem item = new ListViewItem("2000");
                listView1.Items.Add(item);
                item.SubItems.Add("Anders Hejlsberg");
                item.SubItems.Add("ASP.NET Core, Entity Framework Core, Xamarin");
                
           }
            else if (listBox1.SelectedIndex == 1)
            {
                listView1.Items.Clear();
                ListViewItem item = new ListViewItem("1995");
                listView1.Items.Add(item);
                item.SubItems.Add("James Gosling");
                item.SubItems.Add("Spring, Hibernate, Struts");
            }
            else if (listBox1.SelectedIndex == 2)
            {
                listView1.Items.Clear();
                ListViewItem item = new ListViewItem("1991");
                listView1.Items.Add(item);
                item.SubItems.Add("Guido van Rossum");
                item.SubItems.Add("Django, Flask, PyTorch");
            }
      
        }
    }
}
