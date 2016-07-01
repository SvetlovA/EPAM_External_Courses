using Department.BLL;
using Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinForms
{
    public partial class AddOrUpdateRewardForm : Form
    {
        private Reward _reward = new Reward();
        private readonly RewardsBL _rewards;
        private bool _create;

        public AddOrUpdateRewardForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateRewardForm(Reward reward, RewardsBL rewards, bool create = true)
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
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            foreach (var reward in _rewards.GetList())
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
