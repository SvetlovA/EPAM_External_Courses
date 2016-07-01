using Entities;
using System.Collections.Generic;

namespace Department.DAL
{
    public interface IRewardDAO
    {
        void Add(Reward reward);
        void Edit(Reward reward);
        void Delete(Reward reward);
        IEnumerable<Reward> GetList();
    }
}
