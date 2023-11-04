using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CatsAPI.Models;

public partial class BreedType
{
    public int Id { get; set; }

    public string BreedTypeName { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Cat> Cats { get; set; } = new List<Cat>();
}
