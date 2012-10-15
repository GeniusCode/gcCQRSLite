using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GeniusCode.Cqrs.Handlers
{
    public class ReflectionGenericCommandHandlerAdapter : IGeneralCommandHandlerFactory
    {
        private readonly IGenericCommandHandlerFactory _factory;

        public ReflectionGenericCommandHandlerAdapter(IGenericCommandHandlerFactory factory)
        {
            _factory = factory;
        }

        public IEnumerable<ICommandHandlerInfo> GetCommandHandlerInfos(Type commandType)
        {
            var reflectionInfo = GetType().GetMethod("GetCommandHandlersForTypeGeneric", BindingFlags.Instance | BindingFlags.NonPublic);
            var genericReflectionInfo = reflectionInfo.MakeGenericMethod(new[] { commandType });

            return (IEnumerable<ICommandHandlerInfo>)genericReflectionInfo.Invoke(this, null);          
        }

        private IEnumerable<ICommandHandlerInfo> GetCommandHandlersForTypeGeneric<T>()
        {
            var handlers = _factory.GetCommandHandlerInfos<T>();
            return handlers;
        }
    }
}