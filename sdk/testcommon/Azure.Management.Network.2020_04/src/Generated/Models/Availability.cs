// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Availability of the metric. </summary>
    public partial class Availability
    {
        /// <summary> Initializes a new instance of Availability. </summary>
        internal Availability()
        {
        }

        /// <summary> Initializes a new instance of Availability. </summary>
        /// <param name="timeGrain"> The time grain of the availability. </param>
        /// <param name="retention"> The retention of the availability. </param>
        /// <param name="blobDuration"> Duration of the availability blob. </param>
        internal Availability(string timeGrain, string retention, string blobDuration)
        {
            TimeGrain = timeGrain;
            Retention = retention;
            BlobDuration = blobDuration;
        }

        /// <summary> The time grain of the availability. </summary>
        public string TimeGrain { get; }
        /// <summary> The retention of the availability. </summary>
        public string Retention { get; }
        /// <summary> Duration of the availability blob. </summary>
        public string BlobDuration { get; }
    }
}
