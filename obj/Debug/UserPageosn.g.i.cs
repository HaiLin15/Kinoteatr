﻿#pragma checksum "..\..\UserPageosn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70EC71C4F272CB87F2130A3424D3D77179790CA456ED17912FB3CF9E2B85580B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Kinoteatr;
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


namespace Kinoteatr {
    
    
    /// <summary>
    /// UserPageosn
    /// </summary>
    public partial class UserPageosn : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\UserPageosn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MainListView;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\UserPageosn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GenreComboBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\UserPageosn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AgeComboBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\UserPageosn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GenreTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Kinoteatr;component/userpageosn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserPageosn.xaml"
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
            this.MainListView = ((System.Windows.Controls.ListView)(target));
            
            #line 23 "..\..\UserPageosn.xaml"
            this.MainListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GenreComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\UserPageosn.xaml"
            this.GenreComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GenreComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AgeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 60 "..\..\UserPageosn.xaml"
            this.AgeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AgeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GenreTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\UserPageosn.xaml"
            this.GenreTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GenreTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 30 "..\..\UserPageosn.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

