using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CatsAPI.Models;

public partial class FunFact
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Cat> Cats { get; set; } = new List<Cat>();
}
