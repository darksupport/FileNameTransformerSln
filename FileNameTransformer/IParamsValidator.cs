using System;
namespace FileNameTransformer
{
    public interface IParamsValidator
    {
        string Validate(string[] args);
    }
}
