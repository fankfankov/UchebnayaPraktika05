﻿#pragma checksum "..\..\..\View\AMONIC Airlines Automation System.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA2CD8C39A5956352DD5B6CE913C6906F7708AD33CC4D21B5ED6D14B9951E726"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Praktika.View;
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


namespace Praktika.View {
    
    
    /// <summary>
    /// AMONIC_Airlines_Automation_System
    /// </summary>
    public partial class AMONIC_Airlines_Automation_System : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\AMONIC Airlines Automation System.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Add_Btn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\AMONIC Airlines Automation System.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Exit_Btn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\AMONIC Airlines Automation System.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbOffice;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\AMONIC Airlines Automation System.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UsersGrid;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\View\AMONIC Airlines Automation System.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Change_Btn;
        
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
            System.Uri resourceLocater = new System.Uri("/Praktika;component/view/amonic%20airlines%20automation%20system.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AMONIC Airlines Automation System.xaml"
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
            
            #line 10 "..\..\..\View\AMONIC Airlines Automation System.xaml"
            ((Praktika.View.AMONIC_Airlines_Automation_System)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Add_Btn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\View\AMONIC Airlines Automation System.xaml"
            this.Add_Btn.Click += new System.Windows.RoutedEventHandler(this.Add_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Exit_Btn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\View\AMONIC Airlines Automation System.xaml"
            this.Exit_Btn.Click += new System.Windows.RoutedEventHandler(this.Exit_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CmbOffice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\View\AMONIC Airlines Automation System.xaml"
            this.CmbOffice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.All_offices);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UsersGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.Change_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\View\AMONIC Airlines Automation System.xaml"
            this.Change_Btn.Click += new System.Windows.RoutedEventHandler(this.Change_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 48 "..\..\..\View\AMONIC Airlines Automation System.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Enable_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 49 "..\..\..\View\AMONIC Airlines Automation System.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

