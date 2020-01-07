using Autofac;
using Caliburn.Micro;
using System.Linq;
using Xamarin.Forms.Internals;

namespace XCMDEMO
{
    public class Module : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<App>().AsSelf().SingleInstance();

            builder.RegisterType<EventAggregator>().AsSelf().SingleInstance();

            // Registers only classes that match the ViewModel pattern.
            // Registers them as self and as implemented interfaces.
            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ForEach(viewModelType => builder.RegisterType(viewModelType).AsSelf().AsImplementedInterfaces());
        }
    }
}