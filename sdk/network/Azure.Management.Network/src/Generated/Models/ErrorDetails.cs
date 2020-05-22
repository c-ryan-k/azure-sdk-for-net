// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Common error details representation. </summary>
    public partial class ErrorDetails
    {
        /// <summary> Initializes a new instance of ErrorDetails. </summary>
        internal ErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of ErrorDetails. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="target"> Error target. </param>
        /// <param name="message"> Error message. </param>
        internal ErrorDetails(string code, string target, string message)
        {
            Code = code;
            Target = target;
            Message = message;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error target. </summary>
        public string Target { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
    }
}
