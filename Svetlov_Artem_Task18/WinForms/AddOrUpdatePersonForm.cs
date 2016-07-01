using Department.BLL;
using Entities;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
    public partial class AddOrUpdatePersonForm : Form
    {
        private Person _person = new Person();
        private readonly PersonsBL _persons;
        private readonly RewardsBL _rewards;
        private bool _create;

        public AddOrUpdatePersonForm()
        {
            InitializeComponent();
        }

        public AddOrUpdatePersonForm(Person person, PersonsBL persons, RewardsBL rewards, bool create = true)
        {
            InitializeComponent();
            _person = person;
            _rewards = rewards;
            _persons = persons;
            _create = create;
            dateTimePickerBirthday.MinDate = new DateTime(DateTime.Now.Year - 150, 1, 1);
            dateTimePickerBirthday.MaxDate = DateTime.Now;
            if (!create)
            {
                Text = "Редактиование пользователя";
                buttonDelete.Visible = true;
                textBoxFirstName.Text = _person.FirstName;
                textBoxLastName.Text = _person.LastName;
                dateTimePickerBirthday.Value = _person.Birthday;
                foreach (var reward in _person.Rewards.RewardsList)
                {
                    listBoxRewards.Items.Add(reward);
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!_create)
            {
                _person.Rewards.RewardsList.Clear();
            }
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            _person.Birthday = dateTimePickerBirthday.Value.Date;
            foreach (var reward in listBoxRewards.Items)
            {
                _person.Rewards.RewardsList.Add((Reward)reward);
            }
            foreach (var person in _persons.GetList())
            {
                if (_person.FirstName == person.FirstName && _person.LastName == person.LastName && _person.Age == person.Age && _create)
                {
                    throw new Exception("Такой человек уже существует!!!");
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Reward reward = new Reward();

                using (RewardsListForm _rewardListForm = new RewardsListForm(_rewards, listBoxRewards))
                {
                    if (_rewardListForm.ShowDialog() == DialogResult.OK)
                    {
                        listBoxRewards.Items.Add(_rewardListForm.Reward);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Не выбранно никаког значения!!!");
            }
            finally
            {
                DialogResult = DialogResult.None;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRewards.SelectedItems.Count > 0)
            {
                listBoxRewards.Items.Remove(listBoxRewards.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберете элемент, который нужно удалить!!!");
            }
        }

        private void textBoxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text.Trim()))
            {
                errorProvider.SetError(textBoxFirstName, "Вы не ввели Имя!!!");
                e.Cancel = true;
            }
            foreach (var letter in textBoxFirstName.Text.Trim())
            {
                if (char.IsNumber(letter))
                {
                    errorProvider.SetError(textBoxFirstName, "Имя не может содержать цифр!!!");
                    e.Cancel = true;
                }
                if (char.IsWhiteSpace(letter))
                {
                    errorProvider.SetError(textBoxFirstName, "Имя не может состоять из двух слов!!!");
                    e.Cancel = true;
                }
            }
            if (!e.Cancel)
            {
                errorProvider.SetError(textBoxFirstName, string.Empty);
                e.Cancel = false;
            }
        }

        private void textBoxFirstName_Validated(object sender, EventArgs e)
        {
            _person.FirstName = textBoxFirstName.Text.Trim();
        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLastName.Text.Trim()))
            {
                errorProvider.SetError(textBoxLastName, "Вы не ввели Фамилию!!!");
                e.Cancel = true;
            }
            foreach (var letter in textBoxLastName.Text.Trim())
            {
                if (char.IsNumber(letter))
                {
                    errorProvider.SetError(textBoxLastName, "Фамилия не может содержать цифр!!!");
                    e.Cancel = true;
                }
                if (char.IsWhiteSpace(letter))
                {
                    errorProvider.SetError(textBoxLastName, "Фамилия не может состоять из двух слов!!!");
                    e.Cancel = true;
                }
            }
            if (!e.Cancel)
            {
                errorProvider.SetError(textBoxFirstName, string.Empty);
                e.Cancel = false;
            }
        }


        private void textBoxLastName_Validated(object sender, EventArgs e)
        {
            _person.LastName = textBoxLastName.Text.Trim();
        }
    }
}
