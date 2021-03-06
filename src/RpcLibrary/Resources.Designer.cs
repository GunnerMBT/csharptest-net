//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpTest.Net.RpcLibrary
{
    using System;
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This partial class was auto-generated by the StronglyTypedResourceBuilder
    // partial class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal partial class Resources
    {
        private static global::System.Resources.ResourceManager resourceMan;
        private static global::System.Globalization.CultureInfo resourceCulture;
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CSharpTest.Net.RpcLibrary.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
  

        
        /// <summary>
        /// Returns the raw exception strings.
        /// </summary>
        [global::System.Diagnostics.DebuggerStepThroughAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("CSharpTest.Net.Generators", "1.10.1124.356")]
        public static partial class ExceptionStrings
        {
            /// <summary>
            /// Unspecified rpc error
            /// </summary>
            public static string RpcException { get { return ResourceManager.GetString(@"RpcException", resourceCulture); } }
            /// <summary>
            /// {0}
            /// </summary>
            public static string RpcException_String_message_ { get { return ResourceManager.GetString(@"RpcException(String message)", resourceCulture); } }
        }
    
     }

    /// <summary>
    /// Exception class: RpcException : System.ComponentModel.Win32Exception
    /// Unspecified rpc error
    /// </summary>
    [global::System.SerializableAttribute()]
    [global::System.Diagnostics.DebuggerStepThroughAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("CSharpTest.Net.Generators", "1.10.1124.356")]
    public partial class RpcException : System.ComponentModel.Win32Exception
    {
        /// <summary>
        /// Serialization constructor
        /// </summary>
        protected RpcException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
        
        /// <summary>
        /// Unspecified rpc error
        /// </summary>
        public RpcException()
        	: base(global::CSharpTest.Net.RpcLibrary.Resources.ExceptionStrings.RpcException)
        {
        }
        /// <summary>
        /// Unspecified rpc error
        /// </summary>
        public RpcException(Exception innerException)
        	: base(global::CSharpTest.Net.RpcLibrary.Resources.ExceptionStrings.RpcException, innerException)
        {
        }
        /// <summary>
        /// if(condition == false) throws Unspecified rpc error
        /// </summary>
        public static void Assert(bool condition)
        {
            if (!condition) throw new RpcException();
        }
        /// <summary>
        /// {0}
        /// </summary>
        public RpcException(String message)
        	: base(String.Format(global::CSharpTest.Net.RpcLibrary.Resources.ExceptionStrings.RpcException_String_message_, message))
        {
        }
        /// <summary>
        /// {0}
        /// </summary>
        public RpcException(String message, Exception innerException)
        	: base(String.Format(global::CSharpTest.Net.RpcLibrary.Resources.ExceptionStrings.RpcException_String_message_, message), innerException)
        {
        }
        /// <summary>
        /// if(condition == false) throws {0}
        /// </summary>
        public static void Assert(bool condition, String message)
        {
            if (!condition) throw new RpcException(message);
        }
    }


}

