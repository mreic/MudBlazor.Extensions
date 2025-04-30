using MudBlazor.Extensions.Core.W3C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MudBlazor.Extensions.Core.Capture
{
    public class RecordingOptions
    {
        /// <summary>
        /// Indicates, if screen should be recorded seperately
        /// </summary>
        public bool SeperateScreenRecoring { get; set; } = true;

        /// <summary>
        /// Indicates, if system audio should be recorded seperately
        /// </summary>
        public bool SeperateSystemAudioRecoring { get; set; } = true;

        /// <summary>
        /// Indicates, if camera should be recorded seperately
        /// </summary>
        public bool SeperateCameraRecoring { get; set; } = true;

        /// <summary>
        /// Indicates, if mic audio should be recorded seperately
        /// </summary>
        public bool SeperateMicAudioRecoring { get; set; } = true;


        /// <summary>
        /// Options for media recorder to control recording bitrates
        /// </summary>
        [JsonInclude]
        public MediaRecorderOptions MediaRecorderOptions { get; set; } = new();

        /// <summary>
        /// Creates a new instance of <see cref="RecordingOptions"/> setting all seperate streams to no recording.
        /// </summary>
        public static RecordingOptions OnlyCombinedStream => new() { SeperateCameraRecoring = false, SeperateMicAudioRecoring = false, SeperateScreenRecoring = false, SeperateSystemAudioRecoring = false };
    } 
}
