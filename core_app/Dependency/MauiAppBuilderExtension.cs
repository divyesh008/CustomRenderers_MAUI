using System;
using Microsoft.Maui.LifecycleEvents;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class MauiAppBuilderExtension
	{
		public static MauiAppBuilder ConfigMobileUICoreAppBuilder(this MauiAppBuilder builder)
		{
#if ANDROID
			builder.SetupMobileUICoreHandlers();
#elif IOS
			builder.SetupMobileUICoreHandlers();
#endif
            return builder;
		}
	}
}


