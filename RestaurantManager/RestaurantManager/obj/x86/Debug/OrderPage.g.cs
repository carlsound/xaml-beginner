﻿#pragma checksum "C:\Users\john_\Documents\GitHub\xaml-beginner\RestaurantManager\RestaurantManager\OrderPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "27531BF7FAD9FE2D780F61339DB347C9"
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
    partial class OrderPage : 
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
                    global::Windows.UI.Xaml.Controls.AppBarButton element1 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 24 "..\..\..\OrderPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element1).Click += this.navigateToMainPage;
                    #line default
                }
                break;
            case 2:
                {
                    this.ordersListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3:
                {
                    this.specialRequestsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 4:
                {
                    this.orderItemsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5:
                {
                    this.expediteToggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 109 "..\..\..\OrderPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.expediteToggleSwitch).Toggled += this.expediteSwitchToggled;
                    #line default
                }
                break;
            case 6:
                {
                    this.orderPageAddToOrder = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 119 "..\..\..\OrderPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.orderPageAddToOrder).Click += this.addToOrder;
                    #line default
                }
                break;
            case 7:
                {
                    this.orderPageSubmitOrder = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 129 "..\..\..\OrderPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.orderPageSubmitOrder).Click += this.submitOrder;
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

