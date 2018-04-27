using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace AppVersioning.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

#if Dev
            var a = 0;
#elif Staging
            var a = 0;
#elif Prod
            var a = 0;
#else
            var a = 0;
#endif


            return base.FinishedLaunching(app, options);
        }
    }
}
