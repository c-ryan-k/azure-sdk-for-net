// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.EventHub.Models
{
    /// <summary> SKU parameters supplied to the create namespace operation. </summary>
    public partial class Sku
    {
        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        public Sku(SkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        /// <param name="tier"> The billing tier of this particular SKU. </param>
        /// <param name="capacity"> The Event Hubs throughput units, value should be 0 to 20 throughput units. </param>
        internal Sku(SkuName name, SkuTier? tier, int? capacity)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
        }

        /// <summary> Name of this SKU. </summary>
        public SkuName Name { get; set; }
        /// <summary> The billing tier of this particular SKU. </summary>
        public SkuTier? Tier { get; set; }
        /// <summary> The Event Hubs throughput units, value should be 0 to 20 throughput units. </summary>
        public int? Capacity { get; set; }
    }
}
