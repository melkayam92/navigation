﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Navigation.Designer.CustomCode.Validation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Navigation.Designer.CustomCode.Validation.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DialogKey is mandatory for State &apos;{0}&apos;. Any State marked as Initial becomes a Dialog during StateInfo conversion..
        /// </summary>
        internal static string DialogKeyEmpty {
            get {
                return ResourceManager.GetString("DialogKeyEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path is invalid for State &apos;{0}&apos; because it must end with &apos;.aspx&apos; and be made relative using the tilde (~) notation for the application root e.g. &apos;~/Page.aspx&apos;..
        /// </summary>
        internal static string DialogPathInvalid {
            get {
                return ResourceManager.GetString("DialogPathInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DialogResourceType and DialogResourceKey are invalid for State &apos;{0}&apos;. They must either both be populated or both be blank because these are used to localize the Dialog Title..
        /// </summary>
        internal static string DialogResourceInvalid {
            get {
                return ResourceManager.GetString("DialogResourceInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DialogResourceType, DialogResourceKey and DialogTitle are invalid for State &apos;{0}&apos;. If DialogResourceType or DialogResourceKey are populated then DialogTitle should be blank and vice versa..
        /// </summary>
        internal static string DialogTitleAndResourceInvalid {
            get {
                return ResourceManager.GetString("DialogTitleAndResourceInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple Dialogs exist with same DialogKey of &apos;{0}&apos;..
        /// </summary>
        internal static string DuplicateDialogKey {
            get {
                return ResourceManager.GetString("DuplicateDialogKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple States exist within Dialog &apos;{0}&apos; with Key &apos;{1}&apos;..
        /// </summary>
        internal static string DuplicateStateKey {
            get {
                return ResourceManager.GetString("DuplicateStateKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple Transitions exist from State &apos;{0}&apos; with Key &apos;{1}&apos;..
        /// </summary>
        internal static string DuplicateTransitionKey {
            get {
                return ResourceManager.GetString("DuplicateTransitionKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either Path or Route must be set for at least one Dialog/Initial State otherwise a start page or url cannot be specified..
        /// </summary>
        internal static string PathAndRouteEmpty {
            get {
                return ResourceManager.GetString("PathAndRouteEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Defaults is invalid for State &apos;{0}&apos; because it must be in the format Key1=Value1,Key2?type=Value2..
        /// </summary>
        internal static string StateDefaultsInvalid {
            get {
                return ResourceManager.GetString("StateDefaultsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DefaultTypes is invalid for State &apos;{0}&apos; because it must be in the format Key1=type1,Key2=type2..
        /// </summary>
        internal static string StateDefaultTypesInvalid {
            get {
                return ResourceManager.GetString("StateDefaultTypesInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initial should be set to true for State &apos;{0}&apos; because the StateInfo conversion has made it a Dialog..
        /// </summary>
        internal static string StateDialogNotInitial {
            get {
                return ResourceManager.GetString("StateDialogNotInitial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key is mandatory for State because it is used by Dialog and Transition elements to specify configuration..
        /// </summary>
        internal static string StateKeyEmpty {
            get {
                return ResourceManager.GetString("StateKeyEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Masters is invalid for State &apos;{0}&apos;. It must be a comma separated list of master pages, each must end with &apos;.master&apos; and be made relative using the tilde (~) notation for the application root e.g. &apos;Site1.master,Site2.master&apos;.
        /// </summary>
        internal static string StateMastersInvalid {
            get {
                return ResourceManager.GetString("StateMastersInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MobileMasters is invalid for State &apos;{0}&apos;. It must be a comma separated list of master pages, each must end with &apos;.master&apos; and be made relative using the tilde (~) notation for the application root e.g. &apos;Site1.master,Site2.master&apos;.
        /// </summary>
        internal static string StateMobileMastersInvalid {
            get {
                return ResourceManager.GetString("StateMobileMastersInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MobilePage  is invalid for State &apos;{0}&apos; because it must end with &apos;.aspx&apos; and be made relative using the tilde (~) notation for the application root e.g. &apos;~/Page.aspx&apos;..
        /// </summary>
        internal static string StateMobilePageInvalid {
            get {
                return ResourceManager.GetString("StateMobilePageInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page is mandatory for State &apos;{0}&apos; because it is the aspx page to display when navigating..
        /// </summary>
        internal static string StatePageEmpty {
            get {
                return ResourceManager.GetString("StatePageEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page  is invalid for State &apos;{0}&apos; because it must end with &apos;.aspx&apos; and be made relative using the tilde (~) notation for the application root e.g. &apos;~/Page.aspx&apos;..
        /// </summary>
        internal static string StatePageInvalid {
            get {
                return ResourceManager.GetString("StatePageInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ResourceType and ResourceKey are invalid for State &apos;{0}&apos;. They must either both be populated or both be blank because these are used to localize the State Title..
        /// </summary>
        internal static string StateResourceInvalid {
            get {
                return ResourceManager.GetString("StateResourceInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Route should be blank for State &apos;{0}&apos; because the StateInfo conversion has added it to multiple Dialogs..
        /// </summary>
        internal static string StateRouteInvalid {
            get {
                return ResourceManager.GetString("StateRouteInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ResourceType, ResourceKey and Title are invalid for State &apos;{0}&apos;. If ResourceType or ResourceKey are populated then Title should be blank and vice versa..
        /// </summary>
        internal static string StateTitleAndResourceInvalid {
            get {
                return ResourceManager.GetString("StateTitleAndResourceInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key is mandatory for Transition..
        /// </summary>
        internal static string TransitionKeyEmpty {
            get {
                return ResourceManager.GetString("TransitionKeyEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CanNavigateBack is invalid for Transition &apos;{0}&apos; to State &apos;{1}&apos;. A State with TrackCrumbTrail set to false does not support back navigation..
        /// </summary>
        internal static string TransitionWithBackToNoTrackState {
            get {
                return ResourceManager.GetString("TransitionWithBackToNoTrackState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transition &apos;{0}&apos; to State &apos;{1}&apos; is not required. A State marked as Initial becomes a Dialog during StateInfo conversion so a Transition with CanNavigateBack set to false is redundant..
        /// </summary>
        internal static string TransitionWithoutBackToInitialState {
            get {
                return ResourceManager.GetString("TransitionWithoutBackToInitialState", resourceCulture);
            }
        }
    }
}
