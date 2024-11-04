using System.ComponentModel.DataAnnotations;

namespace ABCD.Core.Configuration;

public class AppSettings
{
    [Required]
    public string Environment { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Version { get; set; }
}
