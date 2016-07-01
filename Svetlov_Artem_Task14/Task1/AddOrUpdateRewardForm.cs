using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Task1
{
    public partial class AddOrUpdateRewardForm : Form
    {
        private Reward _reward = new Reward();
        private BindingList<Reward> _rewards = new BindingList<Reward>();
        private bool _create;

        public AddOrUpdateRewardForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateRewardForm(Reward reward, BindingList<Reward> rewards, bool create = true)
        {
            InitializeComponent();
            _reward = reward;
            _rewards = rewards;
            _create = create;
            if (!create)
            {
                Text = "Редактирование награды";
                textBoxTitle.Text = _reward.Title;
                richTextBoxDescription.Text = _reward.Description;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (_create)
            {
                if (_rewards.Count > 0)
                {
                    _reward.Id = 1;
                    foreach (var reward in _rewards)
                    {
                        if (_reward.Id == _rewards.Single(x => x.Id == reward.Id).Id)
                        {
                            _reward.Id++;
                        }
                    }
                }
                else
                {
                    _reward.Id = 1;
                }
            }
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            foreach (var reward in _rewards)
            {
                if (_reward.Title == reward.Title && _create)
                {
                    throw new Exception("Такая награда уже существует!!!");
                }
            }
        }

        private void textBoxTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text.Trim()))
            {
                errorProvider.SetError(textBoxTitle, "Вы не ввели название награды!!!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxTitle, string.Empty);
                e.Cancel = false;
            }
        }

        private void textBoxTitle_Validated(object sender, EventArgs e)
        {
            _reward.Title = textBoxTitle.Text.Trim();
        }

        private void richTextBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBoxDescription.Text.Trim()))
            {
                errorProvider.SetError(richTextBoxDescription, "Описание должно быть заполненно!!!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(richTextBoxDescription, string.Empty);
                e.Cancel = false;
            }
        }

        private void richTextBoxDescription_Validated(object sender, EventArgs e)
        {
            _reward.Description = richTextBoxDescription.Text.Trim();
        }
    }
}
