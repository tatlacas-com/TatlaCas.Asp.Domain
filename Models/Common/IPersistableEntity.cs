using System;
using Microsoft.EntityFrameworkCore;

namespace TatlaCas.Asp.Domain.Models.Common;

public interface IPersistableEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    void OnModelCreating(ModelBuilder builder);
}