using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazor.Extensions.Core.W3C
{
    /// <summary>
    /// Represents options for MediaRecorder-JS Class. Including Video- and Audiobitrate settings.
    /// </summary>
    public class MediaRecorderOptions
    {
        /// <summary>
        /// Represents the bitrate for video recording
        /// </summary>
        public long? VideoBitsPerSecond { get; set; }

        /// <summary>
        /// Represents the bitrate for audio recording
        /// </summary>
        public long? AudioBitsPerSecond { get; set; }
    }
}
