// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.EventHub.Models
{
    /// <summary> Single item in a List or Get IpFilterRules operation. </summary>
    public partial class IpFilterRule : Resource
    {
        /// <summary> Initializes a new instance of IpFilterRule. </summary>
        public IpFilterRule()
        {
        }

        /// <summary> Initializes a new instance of IpFilterRule. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="ipMask"> IP Mask. </param>
        /// <param name="action"> The IP Filter Action. </param>
        /// <param name="filterName"> IP Filter name. </param>
        internal IpFilterRule(string id, string name, string type, string ipMask, IPAction? action, string filterName) : base(id, name, type)
        {
            IpMask = ipMask;
            Action = action;
            FilterName = filterName;
        }

        /// <summary> IP Mask. </summary>
        public string IpMask { get; set; }
        /// <summary> The IP Filter Action. </summary>
        public IPAction? Action { get; set; }
        /// <summary> IP Filter name. </summary>
        public string FilterName { get; set; }
    }
}
