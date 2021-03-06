﻿using Department.BLL;
using Entities;
using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class RewardsListForm : Form
    {
        private Reward _reward = new Reward();

        public RewardsListForm()
        {
            InitializeComponent();
        }

        public RewardsListForm(RewardsBL rewards, ListBox listBoxRewards)
        {
            InitializeComponent();
            foreach (var reward in rewards.GetList())
            {
                if (listBoxRewards.Items.Count > 0)
                {
                    foreach (Reward item in listBoxRewards.Items)
                    {
                        if (reward.Id != item.Id)
                        {
                            comboBoxRewards.Items.Add(reward);
                            break;
                        }
                    }
                }
                else
                {
                    comboBoxRewards.Items.Add(reward);
                }
            }
        }

        public Reward Reward
        {
            get
            {
                return _reward;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _reward = (Reward)comboBoxRewards.SelectedItem;
        }
    }
}
