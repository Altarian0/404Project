﻿#pragma checksum "..\..\..\..\VIews\Pages\AttractionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "499238FA93E35B6E2B20682F459ABC7384B6DE8E15F8B2BDFED697A06B199E08"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using _404Project.VIews.Pages;


namespace _404Project.VIews.Pages {
    
    
    /// <summary>
    /// AttractionPage
    /// </summary>
    public partial class AttractionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AttractionListBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditShop;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddShopBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/404Project;component/views/pages/attractionpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AttractionListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.EditShop = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
            this.EditShop.Click += new System.Windows.RoutedEventHandler(this.EditShopBtn);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddShopBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
            this.AddShopBtn.Click += new System.Windows.RoutedEventHandler(this.AddShopBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\..\VIews\Pages\AttractionPage.xaml"
            this.SearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
