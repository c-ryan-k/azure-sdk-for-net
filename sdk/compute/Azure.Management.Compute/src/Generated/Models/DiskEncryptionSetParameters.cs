// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes the parameter of customer managed disk encryption set resource id that can be specified for disk. &lt;br&gt;&lt;br&gt; NOTE: The disk encryption set resource id can only be specified for managed disk. Please refer https://aka.ms/mdssewithcmkoverview for more details. </summary>
    public partial class DiskEncryptionSetParameters : SubResource
    {
        /// <summary> Initializes a new instance of DiskEncryptionSetParameters. </summary>
        public DiskEncryptionSetParameters()
        {
        }

        /// <summary> Initializes a new instance of DiskEncryptionSetParameters. </summary>
        /// <param name="id"> Resource Id. </param>
        internal DiskEncryptionSetParameters(string id) : base(id)
        {
        }
    }
}
