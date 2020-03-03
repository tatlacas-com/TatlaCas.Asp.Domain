using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TatlaCas.Asp.Domain.Models.Common
{
    public interface IEntity
    {
        int Id { get; set; }
    }


    public abstract class BaseEntity : IEntity
    {
        [Key] public virtual int Id { get; set; }
    }

    public abstract class PersistableEntity : BaseEntity, IPersistableEntity
    {
        public virtual void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity(GetType()).HasKey("Id");
            builder.Entity(GetType()).Property("Id").IsRequired().ValueGeneratedOnAdd();
        }
    }
}