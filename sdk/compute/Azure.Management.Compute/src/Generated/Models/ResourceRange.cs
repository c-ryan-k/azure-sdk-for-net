// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes the resource range. </summary>
    public partial class ResourceRange
    {
        /// <summary> Initializes a new instance of ResourceRange. </summary>
        public ResourceRange()
        {
        }

        /// <summary> Initializes a new instance of ResourceRange. </summary>
        /// <param name="min"> The minimum number of the resource. </param>
        /// <param name="max"> The maximum number of the resource. </param>
        internal ResourceRange(int? min, int? max)
        {
            Min = min;
            Max = max;
        }

        /// <summary> The minimum number of the resource. </summary>
        public int? Min { get; set; }
        /// <summary> The maximum number of the resource. </summary>
        public int? Max { get; set; }
    }
}
