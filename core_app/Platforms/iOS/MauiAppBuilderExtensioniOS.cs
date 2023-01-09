using System;
using core_app.Control;
using core_app.Platforms.iOS.Renderers;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class MauiAppBuilderExtensioniOS
	{
        public static MauiAppBuilder SetupMobileUICoreHandlers(this MauiAppBuilder builder)
        {
            builder.ConfigureMauiHandlers(handler =>
            {
                handler.AddHandler(typeof(NullableDatePicker), typeof(NullDatePickerRenderer));
            });
            return builder;
        }
    }
}

