using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Validation;

namespace RequestValidation.Api;

#pragma warning disable ASP0029 // Explicit metadata is required for this request model in .NET 10.
[ValidatableType]
#pragma warning restore ASP0029
public sealed record ProductInput(
    [property: Required]
    [property: RegularExpression(@".*\S.*")]
    string Name,
    [property: Range(1, 100)]
    int Quantity);
