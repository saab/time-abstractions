using System;
using System.Threading;

namespace Saab.Time
{
    public interface ICancellationTokenSource : IDisposable
    {
        /// <inheritdoc cref="CancellationTokenSource.IsCancellationRequested"/>
        bool IsCancellationRequested { get; }

        /// <inheritdoc cref="CancellationTokenSource.Token"/>
        CancellationToken Token { get; }

        /// <inheritdoc cref="CancellationTokenSource.Cancel()"/>
        void Cancel();

        /// <inheritdoc cref="CancellationTokenSource.Cancel(bool)"/>
        void Cancel(bool throwOnFirstException);

        /// <inheritdoc cref="CancellationTokenSource.CancelAfter(int)"/>
        void CancelAfter(int millisecondsDelay);

        /// <inheritdoc cref="CancellationTokenSource.CancelAfter(TimeSpan)"/>
        void CancelAfter(TimeSpan delay);
    }
}
