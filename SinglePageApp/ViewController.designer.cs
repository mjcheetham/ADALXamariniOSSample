// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SinglePageApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GetTokenButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView TokenTextView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (GetTokenButton != null) {
                GetTokenButton.Dispose ();
                GetTokenButton = null;
            }

            if (TokenTextView != null) {
                TokenTextView.Dispose ();
                TokenTextView = null;
            }
        }
    }
}