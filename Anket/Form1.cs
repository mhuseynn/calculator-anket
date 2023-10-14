using System.Text.Json;

namespace Anket
{
    public partial class Form1 : Form
    {

        List<Anket> ankets = new List<Anket>();

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("../../../Ankets.json"))
            {
                string jsontxt = File.ReadAllText("../../../Ankets.json");
                var list = System.Text.Json.JsonSerializer.Deserialize<List<Anket>>(jsontxt);
                ankets = list;
            }
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            

            string name = name_text.Text;
            string surname = surname_textbox.Text;
            string father_name = father_text.Text;
            string country = country_text.Text;
            string city = city_text.Text;
            string phone = phone_text.Text;
            DateTime birh = date_time.Value.Date;
            string gender;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else { gender = radioButton2.Text; }

            Anket anket = new(name, surname, father_name, country, city, phone, birh, gender);

            for (int i = 0; i < ankets.Count; i++)
            {
                if (ankets[i].name == search.Text)
                {
                    ankets.Remove(ankets[i]);
                    
                    break;
                }
            }
         
    
            ankets.Add(anket);
            JsonSerializerOptions serializerOptions = new JsonSerializerOptions();
            serializerOptions.WriteIndented = true;
            string jsonstr = JsonSerializer.Serialize(ankets, serializerOptions);
            File.WriteAllText("../../../Ankets.json", jsonstr);


            List<TextBox> textboxesToClear = new List<TextBox>
            {
                    name_text, surname_textbox, father_text, country_text, city_text, phone_text
            };


            foreach (TextBox textbox in textboxesToClear)
            {
                textbox.Text = "";
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            date_time.Value = DateTime.Now.Date;
            search.Text = "";
            message.Text = "";
        }

        private void load_bt_Click(object sender, EventArgs e)
        {

            foreach (var item in ankets)
            {
                if (item.name == search.Text)
                {
                    name_text.Text = item.name;
                    surname_textbox.Text = item.surname;
                    father_text.Text = item.father_name;
                    country_text.Text = item.country;
                    city_text.Text = item.city;
                    phone_text.Text = item.telephone;

                    date_time.Value = item.birthday;
                    if (item.gender == "male")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    message.ForeColor = Color.Green;
                    message.Text = "Founded";
                    break;
                }
                message.ForeColor = Color.Red;
                message.Text = "Not found";

            }
        }


    }
}