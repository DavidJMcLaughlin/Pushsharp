﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PushSharpTests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PushSharpTests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {
        ///    &quot;data&quot;: [
        ///        {
        ///            &quot;approved_at_utc&quot;: null,
        ///            &quot;author&quot;: &quot;ExampleAuthor&quot;,
        ///            &quot;author_flair_background_color&quot;: null,
        ///            &quot;author_flair_css_class&quot;: null,
        ///            &quot;author_flair_richtext&quot;: [],
        ///            &quot;author_flair_template_id&quot;: null,
        ///            &quot;author_flair_text&quot;: null,
        ///            &quot;author_flair_text_color&quot;: null,
        ///            &quot;author_flair_type&quot;: &quot;text&quot;,
        ///            &quot;author_fullname&quot;: &quot;t2_000000&quot;,
        ///            &quot;banned_at_utc&quot;: null,
        ///           [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CommentJson {
            get {
                return ResourceManager.GetString("CommentJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;data&quot;: [
        ///        {
        ///            &quot;author&quot;: &quot;ExamplAuthor&quot;,
        ///            &quot;author_flair_css_class&quot;: null,
        ///            &quot;author_flair_richtext&quot;: [],
        ///            &quot;author_flair_text&quot;: null,
        ///            &quot;author_flair_type&quot;: &quot;text&quot;,
        ///            &quot;author_fullname&quot;: &quot;t2_00000000&quot;,
        ///            &quot;can_mod_post&quot;: false,
        ///            &quot;content_categories&quot;: [
        ///                &quot;gaming&quot;
        ///            ],
        ///            &quot;contest_mode&quot;: false,
        ///            &quot;created_utc&quot;: 1537580346,
        ///            &quot;domain&quot;: &quot;self.Example&quot;, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SubmissionJson {
            get {
                return ResourceManager.GetString("SubmissionJson", resourceCulture);
            }
        }
    }
}
