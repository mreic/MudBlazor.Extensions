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
        public bool SeperateScreenRecording { get; set; } = true;

        /// <summary>
        /// Indicates, if system audio should be recorded seperately
        /// </summary>
        public bool SeperateSystemAudioRecording { get; set; } = true;

        /// <summary>
        /// Indicates, if camera should be recorded seperately
        /// </summary>
        public bool SeperateCameraRecording { get; set; } = true;

        /// <summary>
        /// Indicates, if mic audio should be recorded seperately
        /// </summary>
        public bool SeperateMicAudioRecording { get; set; } = true;


        /// <summary>
        /// Options for media recorder to control recording bitrates
        /// </summary>
        [JsonInclude]
        public MediaRecorderOptions MediaRecorderOptions { get; set; } = new();

        /// <summary>
        /// Creates a new instance of <see cref="RecordingOptions"/> setting all seperate streams to no recording.
        /// </summary>
        public static RecordingOptions OnlyCombinedStream => new() { SeperateCameraRecording = false, SeperateMicAudioRecording = false, SeperateScreenRecording = false, SeperateSystemAudioRecording = false };
    } 
}
