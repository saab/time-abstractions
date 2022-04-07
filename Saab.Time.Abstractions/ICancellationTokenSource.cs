using System;
using System.Threading;

namespace Saab.Time.Abstractions
{
    public interface ICancellationTokenSource : IDisposable
    {
        /// <summary>
        /// Gets whether cancellation has been requested for this System.Threading.CancellationTokenSource.
        /// </summary>
        /// <value>
        /// true if cancellation has been requested for this System.Threading.CancellationTokenSource; otherwise, false.
        /// </value>
        bool IsCancellationRequested { get; }

        /// <summary>
        /// Gets the System.Threading.CancellationToken associated with this System.Threading.CancellationTokenSource.
        /// </summary>
        /// <value>
        /// The System.Threading.CancellationToken associated with this System.Threading.CancellationTokenSource.
        /// </value>
        /// <exception cref="ObjectDisposedException">The token source has been disposed.</exception>
        CancellationToken Token { get; }

        /// <summary>
        /// Communicates a request for cancellation.
        /// </summary>
        /// <exception cref="ObjectDisposedException">This System.Threading.CancellationTokenSource has been disposed.</exception>
        /// <exception cref="AggregateException">An aggregate exception containing all the exceptions thrown by the registered callbacks on the associated System.Threading.CancellationToken.</exception>
        void Cancel();

        /// <summary>
        /// Communicates a request for cancellation, and specifies whether remaining callbacks and cancelable operations should be processed.
        /// </summary>
        /// <param name="throwOnFirstException">true if exceptions should immediately propagate; otherwise, false.</param>
        /// <exception cref="ObjectDisposedException">This System.Threading.CancellationTokenSource has been disposed.</exception>
        /// <exception cref="AggregateException">An aggregate exception containing all the exceptions thrown by the registered callbacks on the associated System.Threading.CancellationToken.</exception>
        void Cancel(bool throwOnFirstException);

        /// <summary>
        /// Schedules a cancel operation on this System.Threading.CancellationTokenSource after the specified number of milliseconds.
        /// </summary>
        /// <param name="millisecondsDelay">The time span to wait before canceling this System.Threading.CancellationTokenSource.</param>
        /// <exception cref="ObjectDisposedException">This System.Threading.CancellationTokenSource has been disposed.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The exception thrown when millisecondsDelay is less than -1.</exception>
        void CancelAfter(int millisecondsDelay);

        /// <summary>
        /// Schedules a cancel operation on this System.Threading.CancellationTokenSource after the specified time span.
        /// </summary>
        /// <param name="delay">The time span to wait before canceling this System.Threading.CancellationTokenSource.</param>
        /// <exception cref="ObjectDisposedException">This System.Threading.CancellationTokenSource has been disposed.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The exception that is thrown when delay is less than -1 or greater than Int32.MaxValue.</exception>
        void CancelAfter(TimeSpan delay);
    }
}
