namespace DIO.desafio.listaserie
{
    public class Series : baseEntity
    {
     

        private Genre genre { get; set; }
        private string title { get; set; }
        private string description { get; set; }
        private int year { get; set; }
        private bool deleted{get;set;}

        public Series(int Id, Genre genre, string title, string description, int year, bool deleted)
        {
            this.Id = Id;
            this.genre = genre;
            this.title = title;
            this.description = description;
            this.year = year;
            this.deleted = false;
        }
        public override string ToString()
        {
            string returnString ="";
            returnString += "Genre: " + this.genre + System.Environment.NewLine;
            returnString += "Title: " + this.title + System.Environment.NewLine;
            returnString += "Description: " + this.description + System.Environment.NewLine;
            returnString += "Year: " + this.year ;
            return returnString;
        }
    
    public string returnTitle()
    {
        return this.title;
    }
    public int returnId()
    {
        return this.Id;
    }

    public void Delete(){
        this.deleted = true;
    }
    }



}