﻿namespace LightInject.SampleLibraryWithCompositionRoot
{
    internal class SampleCompositionRoot : ICompositionRoot
    {
        public static int CallCount { get; set; }

        public void Compose(IServiceRegistry serviceRegistry)
        {
            CallCount++;
            serviceRegistry.RegisterAssembly(typeof(SampleCompositionRoot).Assembly);
        }
    }
}
