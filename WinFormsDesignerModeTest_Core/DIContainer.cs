using Microsoft.Extensions.DependencyInjection;

using System;

namespace WinFormsDesignerModeTest_Core
{
    /// <summary>
    /// Allows accessing service instances from IoC container 
    /// from class instances which are not managed by DI 
    /// (e.g. UserControl instances created in Windows Forms designer)
    /// </summary>
    public class DIContainer
    {
        /// <summary>
        /// IoC container
        /// </summary>
        public static IServiceProvider Services { get; set; }

        public static T Get<T>() where T : class
        {
            return Services?.GetRequiredService<T>(); //nullability to avoid crashes when code is executed by the WinForms designer
        }
    }
}
