﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RBX_Alt_Manager.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RBX_Alt_Manager.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;configuration&gt;
        ///  &lt;startup&gt;
        ///    &lt;supportedRuntime version=&quot;v4.0&quot; sku=&quot;.NETFramework,Version=v4.8&quot; /&gt;
        ///  &lt;/startup&gt;
        ///  &lt;appSettings&gt;
        ///    &lt;add key=&quot;log4net.Config&quot; value=&quot;log4.config&quot; /&gt;
        ///    &lt;add key=&quot;log4net.Config.Watch&quot; value=&quot;True&quot; /&gt;
        ///    &lt;add key=&quot;log4net.Internal.Debug&quot; value=&quot;False&quot; /&gt;
        ///    &lt;add key=&quot;ClientSettingsProvider.ServiceUri&quot; value=&quot;&quot; /&gt;
        ///  &lt;/appSettings&gt;
        ///  &lt;runtime&gt;
        ///    &lt;assemblyBinding xmlns=&quot;urn:schemas-microsoft-com:asm.v1&quot;&gt;
        ///      &lt;probing pr [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AppConfig {
            get {
                return ResourceManager.GetString("AppConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap configIcon {
            get {
                object obj = ResourceManager.GetObject("configIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [RBX Alt Manager]
        ///AccountsBG=#1E1F28
        ///AccountsFG=#FFFFFF
        ///ButtonsBG=#292929
        ///ButtonsFG=#FFFFFF
        ///ButtonsBC=#282828
        ///ButtonStyle=Popup
        ///FormsBG=#292929
        ///FormsFG=#FFFFFF
        ///DarkTopBar=True
        ///LightImages=True
        ///LabelsTransparent=True
        ///ShowHeaders=True
        ///TextBoxesBG=#3A3A3A
        ///TextBoxesFG=#FFFFFF
        ///TextBoxesBC=#282828.
        /// </summary>
        internal static string DefaultTheme {
            get {
                return ResourceManager.GetString("DefaultTheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap disc {
            get {
                object obj = ResourceManager.GetObject("disc", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap donation {
            get {
                object obj = ResourceManager.GetObject("donation", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] handle {
            get {
                object obj = ResourceManager.GetObject("handle", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_history_32 {
            get {
                object obj = ResourceManager.GetObject("icons8_history_32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;configuration&gt;
        ///    &lt;configSections&gt;
        ///        &lt;section name=&quot;log4net&quot; type=&quot;log4net.Config.Log4NetConfigurationSectionHandler, log4net&quot; /&gt;
        ///    &lt;/configSections&gt;
        ///
        ///    &lt;log4net&gt;
        ///        &lt;appender name=&quot;RollingFileAppender&quot; type=&quot;log4net.Appender.RollingFileAppender&quot;&gt;
        ///            &lt;file value=&quot;log.txt&quot; /&gt;
        ///            &lt;appendToFile value=&quot;true&quot; /&gt;
        ///            &lt;rollingStyle value=&quot;Size&quot; /&gt;
        ///            &lt;maxSizeRollBackups value=&quot;1&quot; /&gt;
        ///            &lt;maximumFileSize  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Log4Config {
            get {
                return ResourceManager.GetString("Log4Config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nexus_Version = 102
        ///
        ///local Success, Error, Function
        ///
        ///for i=1, 10 do
        ///	Success, Error = pcall(function()
        ///		local Response = (http_request or (syn and syn.request)) { Method = &apos;GET&apos;, Url = &apos;https://raw.githubusercontent.com/ic3w0lf22/Roblox-Account-Manager/master/RBX%20Alt%20Manager/Nexus/AccountControl.cs&apos; }
        ///
        ///		if not Response.Success then error((&apos;HTTP Error %s&apos;):format(Response.StatusCode)) end
        ///
        ///		Function, Error = loadstring(Response.Body, &apos;Nexus&apos;)
        ///
        ///		if not Function then error(Error) end
        ///
        ///		F [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NexusLoader {
            get {
                return ResourceManager.GetString("NexusLoader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap offline {
            get {
                object obj = ResourceManager.GetObject("offline", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap online {
            get {
                object obj = ResourceManager.GetObject("online", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap SaveIconSmall {
            get {
                object obj = ResourceManager.GetObject("SaveIconSmall", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon server_icon_white {
            get {
                object obj = ResourceManager.GetObject("server_icon_white", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ShuffleIcon {
            get {
                object obj = ResourceManager.GetObject("ShuffleIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon team_KX4_icon {
            get {
                object obj = ResourceManager.GetObject("team_KX4_icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon team_KX4_icon_white {
            get {
                object obj = ResourceManager.GetObject("team_KX4_icon_white", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
