using System.Collections.Generic;

namespace TatlaCas.Asp.Domain.Resources
{
    public interface IResource
    {
        public string UniqueKey { get; set; }
        Dictionary<string, List<IResourceOption>> Options { get; set; }
        bool AddAnotherAfterSave { get; set; }
        bool ShowAddAnotherAfterSave { get; set; }
    }
}