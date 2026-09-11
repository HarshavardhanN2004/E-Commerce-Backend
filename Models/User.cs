using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Backend.Models;

public class User
{
    public int UserId { get; set; }

    [Required]
    [StringLength(100)]
    [RegularExpression(@"^[A-Za-z ]+$",ErrorMessage = "Name can contain only letters and spaces.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    [Required]
    [RegularExpression(@"^(Admin|Customer)$",ErrorMessage = "Role must be either Admin or Customer.")]
    public string Role { get; set; } = "Customer";

    public ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}