namespace Trophy
{
    public class Trophy
    {
        private string competition;
        private int year;

        public int id { get; set; }
        
        public string Competition
        {
            get => competition;
            set
            {
                if (value == null)
                {
                    throw new System.ArgumentNullException("Competition cannot be null");
                }
                if (value.Length < 3)
                {
                    throw new System.ArgumentException("Competition must be at least 3 characters long");
                }
                competition = value;
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 1970)
                {
                    throw new System.ArgumentException("Year must be greater than 1970");
                }
                if (value > 2025)
                {
                    throw new System.ArgumentException("Year must be less than 2025");
                }
                year = value;
            }
        }

        public override string ToString()
        {
            return $"Id: {id}, Competition: {Competition}, Year: {Year}";
        }
    }
}
