using Newtonsoft.Json;
using System.Collections.Generic;
using UTNAvanzada2.Common.Models;

namespace UTNAvanzada2.Common.Implementations
{
    public class JsonManager<T> : IJsonManager<T> where T : Entity
    {
        public IList<T> GetContent(string filePath)
        {
            var jsonContent = System.IO.File.ReadAllText(@filePath);

            var content = JsonConvert.DeserializeObject<List<T>>(jsonContent);

            return (content != null) ? content : new List<T>();
        }
    }
}
