using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Task1
{
    public partial class DateBaseForm : Form
    {
        private BindingList<Person> _persons = new BindingList<Person>();
        private BindingList<Reward> _rewards = new BindingList<Reward>();

        public DateBaseForm()
        {
            InitializeComponent();
            dataGridViewPersons.DataSource = _persons;
            dataGridViewRewards.DataSource = _rewards;
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
                    _persons = new BindingList<Person>(_persons.OrderBy((x) => x.Id).ToList());
                    break;
                case 1:
                    _persons = new BindingList<Person>(_persons.OrderBy((x) => x.FirstName).ToList());
                    break;
                case 2:
                    _persons = new BindingList<Person>(_persons.OrderBy((x) => x.LastName).ToList());
                    break;
                case 3:
                    _persons = new BindingList<Person>(_persons.OrderBy((x) => x.Birthday).ToList());
                    break;
                case 4:
                    _persons = new BindingList<Person>(_persons.OrderBy((x) => x.Age).ToList());
                    break;
            }
            dataGridViewPersons.DataSource = _persons;
        }

        private void dataGridViewRewards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    _rewards = new BindingList<Reward>(_rewards.OrderBy((x) => x.Id).ToList());
                    break;
                case 1:
                    _rewards = new BindingList<Reward>(_rewards.OrderBy((x) => x.Title).ToList());
                    break;
                case 2:
                    _rewards = new BindingList<Reward>(_rewards.OrderBy((x) => x.Description).ToList());
                    break;
            }
            dataGridViewRewards.DataSource = _rewards;
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
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
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
                        _persons.Insert(_persons.IndexOf(person), person);
                        _persons.Remove(person);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана строка для изменения!!!");
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

                if (MessageBox.Show("Удалить информацию о пользователе?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _persons.Remove(person);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана строка для удаления!!!");
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
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
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
                        _rewards.Insert(_rewards.IndexOf(reward), reward);
                        _rewards.Remove(reward);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана строка для изменения!!!");
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

                if (MessageBox.Show("Удалить информацию о награде?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var person in _persons)
                    {
                        foreach (var rewarditem in person.Rewards.RewardsList)
                        {
                            if (rewarditem == reward)
                            {
                                person.Rewards.RewardsList.Remove(rewarditem);
                                break;
                            }
                        }
                    }
                    _rewards.Remove(reward);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана строка дляудаления!!!");
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
            if (_persons.Count > 0)
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
            if (_rewards.Count > 0)
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
    }
}
