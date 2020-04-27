using System.Collections.Generic;

namespace TatlaCas.Asp.Domain.Resources
{
    public interface IResource
    {
        public string ViewKey { get; set; }
        public string UniqueKey { get; set; }
        public string CellViewType { get; set; }
        Dictionary<string, List<IResourceOption>> Options { get; set; }
        bool AddAnotherAfterSave { get; set; }
        bool ShowAddAnotherAfterSave { get; set; }
        bool IsValid();
    }
}