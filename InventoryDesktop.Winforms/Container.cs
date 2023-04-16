using Autofac;
using InventoryDesktop.EntityFramework;
using System.Reflection;

namespace InventoryDesktop.Winforms
{
    public static class Container
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<InventoryDbContext>().AsSelf();
            builder.RegisterType<CustomToolStripRenderer>().AsSelf();

            builder.RegisterAssemblyTypes(Assembly.Load("Easy Invent"))
                .Where(t => t.Name.Contains("Form"))
                .AsSelf();

            builder.RegisterAssemblyTypes(Assembly.Load("InventoryDesktop." + nameof(Applications)))
                .Where(t => t.Name.Contains("Service"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            builder.RegisterAssemblyTypes(Assembly.Load("InventoryDesktop." + nameof(EntityFramework)))
                .Where(t => t.Name.Contains("Repository"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
