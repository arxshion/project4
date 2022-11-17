using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace workerkstable
{
    public partial class form1 : Form
    {
        public struct User
        {
            public string name;
            public string pos;
            public int age;
            public int stage;

             

            public User(string _name, string _pos, int _stage ,  int _age)
            {
                name = _name;
                pos = _pos;
                age = _age;
                stage = _stage;

            }
        }
        List<User> users = new List<User>();


        public form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            users.Add(new User("Олександр Богомутов", "Директор", 7 , 2014));
            users.Add(new User("Тетьяна Валентинівна",  "Керівник" , 5 , 2016));
            users.Add(new User("Никита Тендирів",   "Зам Директора", 4 , 2015));
            users.Add(new User("Денис тедорович",  "Охоронець" ,   0, 2020));
            users.Add(new User("Андрій Михалевскьий", "Менеджер", 4, 2018));

            DataTable table = new DataTable();
            table.Columns.Add("імя", typeof(string));
            table.Columns.Add("Посада", typeof(string));
            table.Columns.Add("Рік поступлення на роботу", typeof(int));
            table.Columns.Add("Стаж", typeof(int));


            for (int i= 0; i < users.Count; i++)
            {
                table.Rows.Add(users[i].name, users[i].pos, users[i].age, users[i].stage);
            }

            dataGridView1.DataSource = table;

        } 

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = new string[10];

            for (int i = 0; i < users.Count; i++)
            {
               
                if (users[i].stage >= Convert.ToInt32(textBox1.Text))
                {
                    for(int p = 0; p < users.Count; p++)
                    {
                        str[p] = users[i].name;
                    }
                }

            }
            for (int p = 0; p < users.Count; p++)
            {
                MessageBox.Show(str[p]);      
            }
        }
    }
}
