﻿#pragma checksum "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D585C8EDBC9FDEBD695D9890907AE6586CA5C5FFF48CAA6F2597A599EB82B8B1"
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
using _404Project.VIews.Forms.ProductFolder;


namespace _404Project.VIews.Forms.ProductFolder {
    
    
    /// <summary>
    /// AddProductForm
    /// </summary>
    public partial class AddProductForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImageLinkBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddImageBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PictureBox;
        
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
            System.Uri resourceLocater = new System.Uri("/404Project;component/views/forms/productfolder/addproductform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
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
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PriceBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
            this.CancelBtn.Click += new System.Windows.RoutedEventHandler(this.CancelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImageLinkBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
            this.ImageLinkBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ImageLinkBtn_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddImageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\VIews\Forms\ProductFolder\AddProductForm.xaml"
            this.AddImageBtn.Click += new System.Windows.RoutedEventHandler(this.AddImageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PictureBox = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
