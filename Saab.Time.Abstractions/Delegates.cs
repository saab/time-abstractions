using System;
using System.Threading;
using System.Threading.Tasks;

namespace Saab.Time
{
    public delegate DateTime UtcNow();

    public delegate CancellationTokenSource CreateCancellationTokenSource(TimeSpan timeout);

    public delegate Task TaskDelay(TimeSpan timeout, CancellationToken ct = default);

    public delegate ITimer CreateTimer();
}
