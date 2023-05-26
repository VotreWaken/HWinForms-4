using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
using static HWinForms.Form1;

namespace HWinForms
{
    public partial class Form1 : Form
    {
        public List<Questionary> QuestionaryList = new List<Questionary>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddQuestionary(object sender, EventArgs e)
        {
            Questionary que = new Questionary(TBName.Text, TBSurname.Text, TBEmail.Text, TBNumber.Text);
            if (CheckValidate() == true)
            {
                QuestionaryList.Add(que);
                LBQuestionary.DisplayMember = "Name";
                LBQuestionary.Items.Add(que);
                ClearTextBoxes();
            }
        }
        private bool CheckValidate()
        {
            if (string.IsNullOrEmpty(TBName.Text) || string.IsNullOrEmpty(TBSurname.Text)
                || string.IsNullOrEmpty(TBEmail.Text) || string.IsNullOrEmpty(TBNumber.Text))
            {
                MessageBox.Show("Enter Correct Input Data");
                return false;
            }
            return true;
        }
        private void ClearTextBoxes()
        {
            TBName.Text = string.Empty;
            TBSurname.Text = string.Empty;
            TBEmail.Text = string.Empty;
            TBNumber.Text = string.Empty;
        }

        [Serializable]
        [DataContract]
        public class Questionary
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string Surname { get; set; }
            [DataMember]
            public string Email { get; set; }
            [DataMember]
            public string Phone { get; set; }

            public Questionary() { }
            public Questionary(string name, string surname, string email, string phone)
            {
                Name = name;
                Surname = surname;
                Email = email;
                Phone = phone;
            }

            public override string ToString()
            {
                return $"\nName: {Name}" +
                    $"\nSurname: {Surname}" +
                    $"\nEmail: {Email}" +
                    $"\nNumber: {Phone}";
            }
        }

        private void LBQuestionary_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (list.SelectedItem == null)
            {
                return;
            }
            DialogResult result = MessageBox.Show(list.SelectedItem.ToString());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LBQuestionary.SelectedItem == null)
            {
                return;
            }
            LBQuestionary.Items.Remove(LBQuestionary.SelectedItem);
            ClearTextBoxes();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (LBQuestionary.SelectedItem == null)
            {
                return;
            }
            else if (CheckValidate() == true)
            {
                LBQuestionary.Items.Remove(LBQuestionary.SelectedItem);
                LBQuestionary.Items.Add(new Questionary(TBName.Text, TBSurname.Text, TBEmail.Text, TBNumber.Text));
                ClearTextBoxes();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Questionary.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Questionary>));
            serializer.Serialize(stream, QuestionaryList);
            stream.Close();
        }
    }
}