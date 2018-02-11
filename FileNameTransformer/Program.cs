using FileNameTransformer.TransformerActions;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace FileNameTransformer
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(nameof(Program));


        static async void transformAndSave(string[] args)
        {
            try
            {
                IDirectoryFileNameTransformer transformer = new DirectoryFileNameTransformer(args[0], Globals.Container.Resolve<IAction>(args[1]));
                List<string> fileNames = await transformer.GetAllFilesInDirAsync();
                Task<List<string>> result = transformer.TransformFileNamesAsync(fileNames);

                ISaveResults saver = Globals.Container.Resolve<ISaveResults>();
                Task saveResult = saver.SaveToFile(result, Globals.ResultFileName);

                Console.ReadLine();
                await saveResult; //prevent exit before result was saved
            }
            catch (Exception e)
            {
                log.Fatal(ResourceStrings.FatalError, e);
            }
        }

        static void Main(string[] args)
        {
            IParamsValidator validator = Globals.Container.Resolve<IParamsValidator>();
            string validationResult = validator.Validate(args);
             if (validationResult != string.Empty)
             {
                 Console.WriteLine(validationResult);
                 return;
             }

            transformAndSave(args);
        }
    }
}
