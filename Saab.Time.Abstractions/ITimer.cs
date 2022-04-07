using System;
using System.Timers;

namespace Saab.Time
{
    public interface ITimer : IDisposable
    {
        bool AutoReset { get; set; }

        bool Enabled { get; set; }

        /// <summary>
        ///     Number of milliseconds between <see cref="Elapsed"/> events being triggered.
        /// </summary>
        double Interval { get; set; }

        void Start();

        void Stop();

        event ElapsedEventHandler Elapsed;
    }
}