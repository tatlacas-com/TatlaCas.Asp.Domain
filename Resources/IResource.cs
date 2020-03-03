using System.Collections.Generic;
using TatlaCas.Asp.Utils.Utils;

namespace TatlaCas.Asp.Domain.Resources
{
    public interface IResource
    {
        Dictionary<string, List<IResourceOption>> Options { get; set; }
        bool AddAnotherAfterSave { get; set; }
        bool ShowAddAnotherAfterSave { get; set; }
    }
}