namespace Domain.Entity;

public class Session
{
    public Guid ID { get; private set; }
    public Guid UserID { get; set; }
    public Guid RefreshToken { get; private set; }
    public string FingerPrint { get; set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public DateTime ExpiredAt { get; private set; }

    public Session(Guid userID, string fingerPrint)
    {
        ID = Guid.NewGuid();
        UserID = userID;
        RefreshToken = Guid.NewGuid();
        FingerPrint = fingerPrint;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
        ExpiredAt = UpdatedAt.AddDays(14); // add sameTime from config
    }
}
