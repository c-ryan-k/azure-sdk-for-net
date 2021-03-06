// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Job output scheduled event data. </summary>
    public partial class MediaJobOutputScheduledEventData : MediaJobOutputStateChangeEventData
    {
        /// <summary> Initializes a new instance of MediaJobOutputScheduledEventData. </summary>
        internal MediaJobOutputScheduledEventData()
        {
        }

        /// <summary> Initializes a new instance of MediaJobOutputScheduledEventData. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="output"> Gets the output. </param>
        /// <param name="jobCorrelationData"> Gets the Job correlation data. </param>
        internal MediaJobOutputScheduledEventData(MediaJobState? previousState, MediaJobOutput output, IReadOnlyDictionary<string, string> jobCorrelationData) : base(previousState, output, jobCorrelationData)
        {
        }
    }
}
