﻿#pragma checksum "..\..\Inscription.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B1F12158C639E2E926EC4231A4C782881E6F7CE7DE58560F16769E4A94F87B97"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Cooking;
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


namespace Cooking {
    
    
    /// <summary>
    /// Inscription
    /// </summary>
    public partial class Inscription : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_estCreateur_inscription;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button boutton_fini_inscription;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_idClient;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_mdp;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_nom;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_prenom;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_adresse;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_ville;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_tel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Inscription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_mail;
        
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
            System.Uri resourceLocater = new System.Uri("/Cooking;component/inscription.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Inscription.xaml"
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
            this.checkbox_estCreateur_inscription = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.boutton_fini_inscription = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Inscription.xaml"
            this.boutton_fini_inscription.Click += new System.Windows.RoutedEventHandler(this.boutton_fini_inscription_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textbox_idClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textbox_mdp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textbox_nom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textbox_prenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textbox_adresse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.textbox_ville = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.textbox_tel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.textbox_mail = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

