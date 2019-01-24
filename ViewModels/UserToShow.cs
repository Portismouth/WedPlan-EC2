namespace WeddingPlanner.ViewModels
{
    public class UserToShow
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        {
            get 
            {
                return FirstName + " " + LastName;
            }
        }
    }
}