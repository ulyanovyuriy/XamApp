using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamMaket.Services
{
    public class ServiceExecutor
    {
        private readonly Dictionary<Type, Type> _typeMap = new Dictionary<Type, Type>();

        private readonly Dictionary<Type, object> _instanceMap = new Dictionary<Type, object>();

        public static ServiceExecutor Default;

        static ServiceExecutor()
        {
            Default = new ServiceExecutor();

            Default.RegisterInstance<INavigationService>(new NavigationService());
        }

        public void RegisterInstance<T>(T instance)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            _instanceMap[typeof(T)] = instance;
        }

        public void RegisterType<Tin, Tout>()
        {
            _typeMap[typeof(Tin)] = typeof(Tout);
        }

        public object Resolve(Type type)
        {
            object obj;
            if (_instanceMap.TryGetValue(type, out obj))
                return obj;

            Type objType;
            if (_typeMap.TryGetValue(type, out objType))
                return Activator.CreateInstance(objType);

            throw new Exception($"Type {type.FullName} not registered");
        }

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        public Task<TResult> ExecuteAsync<TContract, TResult>(Func<TContract, Task<TResult>> func)
        {
            var instance = Resolve<TContract>();
            var result = func(instance);
            return result;
        }

        public Task ExecuteAsync<TContract>(Func<TContract, Task> func)
        {
            var instance = Resolve<TContract>();
            var result = func(instance);
            return result;
        }
    }
}
