﻿#pragma checksum "C:\Users\john_\Documents\GitHub\xaml-beginner\RestaurantManager\RestaurantManager\ExpeditePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD30C8D5510214E06011532D9F4F4815"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManager
{
    partial class ExpeditePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.ordersGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 2:
                {
                    this.expeditePageClearAllOrders = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\ExpeditePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.expeditePageClearAllOrders).Click += this.clearAllOrders;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element3 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 28 "..\..\..\ExpeditePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element3).Click += this.navigateToMainPage;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

