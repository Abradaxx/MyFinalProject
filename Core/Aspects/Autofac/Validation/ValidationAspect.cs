using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Core.Utilities.Interceptors.MethodInterceptionBaseAttribute;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir dogrulama sınıfı degil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            //reflaction çalışma anında bir şeyleri çalıştırabilme şeylerini sağlıyor bir şeyi newliyoruz ya siz bunu çalışma anında yapmak istiyorsunjuz
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//product tipinin çalışma tipini bul diyo
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
