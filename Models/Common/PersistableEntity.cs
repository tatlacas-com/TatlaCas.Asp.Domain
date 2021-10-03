using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TatlaCas.Asp.Domain.Models.Common
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }


    public abstract class BaseEntity : IEntity
    {
        [Key] public virtual Guid Id { get; set; }
    }

    public abstract class PersistableEntity<T> : BaseEntity, IPersistableEntity where T : class, IEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string SearchProp => null;
        public void OnModelCreating(ModelBuilder builder)
        {
            var pi = GetType().GetProperty(nameof(Id));
            if (pi != null && !Attribute.IsDefined(pi, typeof(NotMappedAttribute)))
            {
                var x = builder.Entity<T>();
                x.HasKey(p => p.Id);
                x.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            }

            OnModelCreating(builder.Entity<T>());
        }

        public virtual void OnModelCreating(EntityTypeBuilder<T> builder)
        {
        }
    }
}