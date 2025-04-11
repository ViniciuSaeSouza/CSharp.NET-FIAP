using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TDSPK.Infrastructure.Persistence;

public class Photo
{
    public Guid Id { get; private set; }
    [Required]
    [Url]
    public string Url { get; set; }
    
    public int Length { get; set; }
    
    public DateTime Date { get;  private set; }
    public User User { get; set; }
    public Guid UserId { get; private set; }

    public Photo(string url, Guid userId)
    {
        if (url == string.Empty) throw new Exception();
        Id = Guid.NewGuid();
        Date = DateTime.Now;
        Url = url;
    }

    private void ValidateUrl(string url)
    {
        //Manda o erro para a aplicação de log
        if (string.IsNullOrWhiteSpace(url)) 
            throw new Exception("URL não pode ser nula ou vazia.");

        if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) 
            throw new Exception("URL inválida.");
    }


    internal static Photo Create(string url, Guid id)
    {
        return new Photo(url, id);
    }

}
