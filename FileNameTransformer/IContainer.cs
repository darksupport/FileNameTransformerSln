using System;
namespace FileNameTransformer
{
    public interface IContainer
    {
        T Resolve<T>();
        T Resolve<T>(string namedStrategy);
        Unity.IUnityContainer UnityContainer { get; }
    }
}
