// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.DigitalTwins.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the SKU of the DigitalTwinsInstance.
    /// </summary>
    public partial class DigitalTwinsSkuInfo
    {
        /// <summary>
        /// Initializes a new instance of the DigitalTwinsSkuInfo class.
        /// </summary>
        public DigitalTwinsSkuInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for DigitalTwinsSkuInfo class.
        /// </summary>
        static DigitalTwinsSkuInfo()
        {
            Name = "F1";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// The name of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public static string Name { get; private set; }

    }
}
