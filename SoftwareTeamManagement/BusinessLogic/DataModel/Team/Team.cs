namespace SoftwareTeamManagement.BusinessLogic.DataModel.Team
{
    public record class Team : ITeamContract
    {
        private int _id;
        private string _name;
        private string _description;

        public Team(int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }

        public Team(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public Team()
        {
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }




    }
}
