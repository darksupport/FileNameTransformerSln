using FileNameTransformer.TransformerActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace FileNameTransformer
{
    public class Container : IContainer 
    {

        IUnityContainer container;

        public IUnityContainer UnityContainer
        {
            get { return container; }
        }

        public Container()
        {
            registerDependency();
        }

        IUnityContainer registerDependency()
        {
            container = new UnityContainer();
            container.RegisterType<IAction, AllPath>(Globals.TransformTypes.AllTransformType);
            container.RegisterType<IAction, FindCpp>(Globals.TransformTypes.CppTransformType);
            container.RegisterType<IAction, ReversePath>(Globals.TransformTypes.ReversePathTransformType);
            container.RegisterType<IAction, ReverseSymbolsInPath>(Globals.TransformTypes.ReverseSympolsTransformType);
            container.RegisterType<IParamsValidator, ParamsValidator>();
            container.RegisterType<ISaveResults, SaveResults>();
            return container;
        }
    
        public T Resolve<T>(string namedStrategy)
        {
            return this.container.Resolve<T>(namedStrategy);
        }

        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }

      
    }
}
