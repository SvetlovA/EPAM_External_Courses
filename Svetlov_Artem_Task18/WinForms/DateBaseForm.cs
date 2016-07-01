using Department.BLL;
using Entities;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
    public partial class DateBaseForm : Form
    {
        private readonly PersonsBL _persons;
        private readonly RewardsBL _rewards;

        public DateBaseForm()
        {
            bool sql = false;
            if (MessageBox.Show("Использовать базу данных?", "Выбор режима работы", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                sql = true;
            }
            InitializeComponent();
            _persons = new PersonsBL(sql);
            _rewards = new RewardsBL(sql);
            dataGridViewPersons.DataSource = _persons.GetList();
            dataGridViewRewards.DataSource = _rewards.GetList();
        }

        /// <summary>
        /// Display persons and rewards
        /// </summary>
        private void Display()
        {
            dataGridViewPersons.DataSource = new BindingList<Person>(_persons.GetList().ToList());
            dataGridViewRewards.DataSource = new BindingList<Reward>(_rewards.GetList().ToList());
        }

        private void добавитьЧеловекаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void изменитьДанныеОЧеловекеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPerson();
        }

        private void удалитьДанныеОЧеловекеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePerson();
        }

        private void добавитьНаградуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReward();
        }

        private void редактироватьНаградуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditReward();
        }

        private void удалитьНаградуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteReward();
        }

        private void dataGridViewPersons_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    dataGridViewPersons.DataSource = new BindingList<Person>(_persons.SortByID().ToList());
                    break;
                case 1:
                    dataGridViewPersons.DataSource = new BindingList<Person>(_persons.SortByFirstName().ToList());
                    break;
                case 2:
                    dataGridViewPersons.DataSource = new BindingList<Person>(_persons.SortByLastName().ToList());
                    break;
                case 3:
                    dataGridViewPersons.DataSource = new BindingList<Person>(_persons.SortByBirthday().ToList());
                    break;
                case 4:
                    dataGridViewPersons.DataSource = new BindingList<Person>(_persons.SortByAge().ToList());
                    break;
                case 5:
                    dataGridViewPersons.DataSource = new BindingList<Person>(_persons.SortByRewardsCount().ToList());
                    break;
            }
        }

        private void dataGridViewRewards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    dataGridViewRewards.DataSource = new BindingList<Reward>(_rewards.SortByID().ToList());
                    break;
                case 1:
                    dataGridViewRewards.DataSource = new BindingList<Reward>(_rewards.SortByTitle().ToList());
                    break;
                case 2:
                    dataGridViewRewards.DataSource = new BindingList<Reward>(_rewards.SortByDescription().ToList());
                    break;
            }
        }

        private void добавитьЧеловекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void dataGridViewPersons_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridViewPersons.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridViewPersons.ClearSelection();
                    dataGridViewPersons.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        /// <summary>
        /// Add person
        /// </summary>
        private void AddPerson()
        {
            try
            {
                Person person = new Person();

                using (AddOrUpdatePersonForm addPerson = new AddOrUpdatePersonForm(person, _persons, _rewards))
                {
                    if (addPerson.ShowDialog() == DialogResult.OK)
                    {
                        _persons.Add(person);
                        Display();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit person
        /// </summary>
        private void EditPerson()
        {
            try
            {
                Person person = (Person)dataGridViewPersons.SelectedCells[0].OwningRow.DataBoundItem;

                using (AddOrUpdatePersonForm updatePerson = new AddOrUpdatePersonForm(person, _persons, _rewards, false))
                {
                    if (updatePerson.ShowDialog() == DialogResult.OK)
                    {
                        _persons.Edit(person);
                        Display();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана строка для изменения!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Delete person
        /// </summary>
        private void DeletePerson()
        {
            try
            {
                Person person = (Person)dataGridViewPersons.SelectedCells[0].OwningRow.DataBoundItem;

                if (MessageBox.Show("Удалить информацию о пользователе?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _persons.Delete(person);
                    Display();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана строка для удаления!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add reward
        /// </summary>
        private void AddReward()
        {
            try
            {
                Reward reward = new Reward();

                using (AddOrUpdateRewardForm addHonor = new AddOrUpdateRewardForm(reward, _rewards))
                {
                    if (addHonor.ShowDialog() == DialogResult.OK)
                    {
                        _rewards.Add(reward);
                        Display();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit reward
        /// </summary>
        private void EditReward()
        {
            try
            {
                Reward reward = (Reward)dataGridViewRewards.SelectedCells[0].OwningRow.DataBoundItem;

                using (AddOrUpdateRewardForm updateHonor = new AddOrUpdateRewardForm(reward, _rewards, false))
                {
                    if (updateHonor.ShowDialog() == DialogResult.OK)
                    {
                        _rewards.Edit(reward);
                        Display();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана строка для изменения!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Delete reward
        /// </summary>
        private void DeleteReward()
        {
            try
            {
                Reward reward = (Reward)dataGridViewRewards.SelectedCells[0].OwningRow.DataBoundItem;

                if (MessageBox.Show("Удалить информацию о награде?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _rewards.Delete(reward, _persons.GetList());
                    Display();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана строка для удаления!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьЧеловекаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void редактироватьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPerson();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePerson();
        }

        private void добавитьНаградуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddReward();
        }

        private void редактироватьНаградуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditReward();
        }

        private void удалитьНаградуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteReward();
        }

        private void добавитьНаградуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddReward();
        }

        private void dataGridViewRewards_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridViewRewards.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridViewRewards.ClearSelection();
                    dataGridViewRewards.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        private void dataGridViewPersons_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_persons.GetList().ToList().Count > 0)
            {
                изменитьДанныеОЧеловекеToolStripMenuItem.Enabled = true;
                удалитьДанныеОЧеловекеToolStripMenuItem.Enabled = true;
            }
            else
            {
                изменитьДанныеОЧеловекеToolStripMenuItem.Enabled = false;
                удалитьДанныеОЧеловекеToolStripMenuItem.Enabled = false;
            }
        }

        private void dataGridViewRewards_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_rewards.GetList().ToList().Count > 0)
            {
                редактироватьНаградуToolStripMenuItem.Enabled = true;
                удалитьНаградуToolStripMenuItem.Enabled = true;
            }
            else
            {
                редактироватьНаградуToolStripMenuItem.Enabled = false;
                удалитьНаградуToolStripMenuItem.Enabled = false;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DateBaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _persons.Dispose();
            _rewards.Dispose();
        }
    }
}
