namespace MeetingApp.Models
{ 

     public class MeetingInfo
    {
    public int Id { get; set; }
    public int Index { get; set; }   

     public string? Location { get; set; }

    public DateTime Date { get; set; }

    public int NumberofPeople { get; set; }
    }


}