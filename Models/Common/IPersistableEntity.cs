using Microsoft.EntityFrameworkCore;

namespace TatlaCas.Asp.Domain.Models.Common
{
    public interface IPersistableEntity
    {
        void OnModelCreating(ModelBuilder builder);
    }
}