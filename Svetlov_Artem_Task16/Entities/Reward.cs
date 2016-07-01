namespace Entities
{
    public class Reward
    {
        private int _id;
        private string _title;
        private string _description;

        /// <summary>
        /// ID of reward
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Title of reward
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        /// <summary>
        /// Description of reward
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        /// <summary>
        /// Owerriding tostring for reward
        /// </summary>
        /// <returns> Title of reward</returns>
        public override string ToString()
        {
            return _title;
        }
    }
}
