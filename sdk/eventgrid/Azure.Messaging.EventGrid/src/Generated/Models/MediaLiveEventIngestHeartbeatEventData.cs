// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Ingest fragment dropped event data. Schema of the data property of an EventGridEvent for a Microsoft.Media.LiveEventIngestHeartbeat event. </summary>
    public partial class MediaLiveEventIngestHeartbeatEventData
    {
        /// <summary> Initializes a new instance of MediaLiveEventIngestHeartbeatEventData. </summary>
        internal MediaLiveEventIngestHeartbeatEventData()
        {
        }

        /// <summary> Initializes a new instance of MediaLiveEventIngestHeartbeatEventData. </summary>
        /// <param name="trackType"> Gets the type of the track (Audio / Video). </param>
        /// <param name="trackName"> Gets the track name. </param>
        /// <param name="bitrate"> Gets the bitrate of the track. </param>
        /// <param name="incomingBitrate"> Gets the incoming bitrate. </param>
        /// <param name="lastTimestamp"> Gets the last timestamp. </param>
        /// <param name="timescale"> Gets the timescale of the last timestamp. </param>
        /// <param name="overlapCount"> Gets the fragment Overlap count. </param>
        /// <param name="discontinuityCount"> Gets the fragment Discontinuity count. </param>
        /// <param name="nonincreasingCount"> Gets Non increasing count. </param>
        /// <param name="unexpectedBitrate"> Gets a value indicating whether unexpected bitrate is present or not. </param>
        /// <param name="state"> Gets the state of the live event. </param>
        /// <param name="healthy"> Gets a value indicating whether preview is healthy or not. </param>
        internal MediaLiveEventIngestHeartbeatEventData(string trackType, string trackName, long? bitrate, long? incomingBitrate, string lastTimestamp, string timescale, long? overlapCount, long? discontinuityCount, long? nonincreasingCount, bool? unexpectedBitrate, string state, bool? healthy)
        {
            TrackType = trackType;
            TrackName = trackName;
            Bitrate = bitrate;
            IncomingBitrate = incomingBitrate;
            LastTimestamp = lastTimestamp;
            Timescale = timescale;
            OverlapCount = overlapCount;
            DiscontinuityCount = discontinuityCount;
            NonincreasingCount = nonincreasingCount;
            UnexpectedBitrate = unexpectedBitrate;
            State = state;
            Healthy = healthy;
        }

        /// <summary> Gets the type of the track (Audio / Video). </summary>
        public string TrackType { get; }
        /// <summary> Gets the track name. </summary>
        public string TrackName { get; }
        /// <summary> Gets the bitrate of the track. </summary>
        public long? Bitrate { get; }
        /// <summary> Gets the incoming bitrate. </summary>
        public long? IncomingBitrate { get; }
        /// <summary> Gets the last timestamp. </summary>
        public string LastTimestamp { get; }
        /// <summary> Gets the timescale of the last timestamp. </summary>
        public string Timescale { get; }
        /// <summary> Gets the fragment Overlap count. </summary>
        public long? OverlapCount { get; }
        /// <summary> Gets the fragment Discontinuity count. </summary>
        public long? DiscontinuityCount { get; }
        /// <summary> Gets Non increasing count. </summary>
        public long? NonincreasingCount { get; }
        /// <summary> Gets a value indicating whether unexpected bitrate is present or not. </summary>
        public bool? UnexpectedBitrate { get; }
        /// <summary> Gets the state of the live event. </summary>
        public string State { get; }
        /// <summary> Gets a value indicating whether preview is healthy or not. </summary>
        public bool? Healthy { get; }
    }
}
