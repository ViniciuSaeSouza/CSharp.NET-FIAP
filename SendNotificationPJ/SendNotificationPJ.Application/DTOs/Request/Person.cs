using System.ComponentModel.DataAnnotations;

namespace SendNotificationPJ.Application.DTOs.Request;

public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
}