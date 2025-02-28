using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TDSPK.Persistence;

[Table("Photos")]
public class Photo
{
    [Key]
    public int Id { get; private set; }
    [Required]
    public User User { get; set; }
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
