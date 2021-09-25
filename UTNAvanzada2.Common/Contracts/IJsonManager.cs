using System.Collections.Generic;
using UTNAvanzada2.Common.Models;

namespace UTNAvanzada2.Common
{
    public interface IJsonManager<T>  where T : Entity
    {
        IList<T> GetContent(string filePath);
    }
}
