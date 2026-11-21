using System.ComponentModel.DataAnnotations; namespace self_learning.Models
{
public class Student
{
public int Id { get; set; }
[Required]
[StringLength(50, MinimumLength = 2)] public string Name { get; set; }

[Required] [EmailAddress]
public string Email { get; set; }
[Required]
[StringLength(60, MinimumLength = 2)] public string Course { get; set; }
[Required] [Range(1, 8)]
public int? Semester { get; set; }
}
}
