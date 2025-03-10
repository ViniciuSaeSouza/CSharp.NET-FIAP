using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TDSPK.Infrastructure.Persistence;

public class Photo
{
    
    public int Id { get; private set; }
    
    //public User User { get; set; }
    
    [Required]
    [Url]
    public string Url { get; set; }
    
    public int Length { get; set; }
    
    public DateTime Date { get; private set; }

    public Photo(string url)
    {
        if (url == string.Empty) throw new Exception();

        Id = 1;
        Date = DateTime.Now;
        Url = url;
    }

}
