using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazor.Extensions.Core.Capture
{
    public static class CaptureOptionsExtensions
    {
        /// <summary>
        /// Creates a new instance of <see cref="CaptureOptions"/> setting the current <see cref="RecordingOptions"/> to <see cref="RecordingOptions.OnlyCombinedStream"/>.
        /// </summary>
        public static CaptureOptions OnlyCombinedStream(this CaptureOptions options)
        {
            options.RecordingOptions = RecordingOptions.OnlyCombinedStream;
            return options;
        }
    }
}
