using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameTransformer
{
    public class SaveResults : ISaveResults 
    {
        public async Task SaveToFile(Task<List<string>> dataToSave,string resultFileName)
        {
            File.WriteAllLines(resultFileName, await dataToSave);
        }
    }
}
