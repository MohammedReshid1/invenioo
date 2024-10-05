using System.ComponentModel.DataAnnotations;

namespace invenio.Models.Dtos;

public class CustomerDto
{
    [Key] public Guid CustomerId { get; set; }
    public string Name { get; set; }
    public string LogoPath { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string DeliveryAddress { get; set; }
    public string Email { get; set; }
    public string PrimaryPhoneNumber { get; set; }
    public string? SecondaryPhoneNumber { get; set; }
}

public class CreateCustomerDto
{
    [Required] public string Name { get; set; }
    [Required] public string Country { get; set; }
    [Required] public string City { get; set; }
    [Required] public string DeliveryAddress { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string PrimaryPhoneNumber { get; set; }
    public IFormFile? Logo { get; set; }
    public string? SecondaryPhoneNumber { get; set; }
}

public class UpdateCustomerDto
{
    public string? Name { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? DeliveryAddress { get; set; }
    public string? Email { get; set; }
    public string? PrimaryPhoneNumber { get; set; }
    public IFormFile? Logo { get; set; }
    public string? SecondaryPhoneNumber { get; set; }
}