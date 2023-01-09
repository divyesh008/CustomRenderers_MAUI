using System;
using core_app.Control;
using core_app.Platforms.Android.Renderers;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class MauiAppBuilderExtensionAndroid
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

