using System = System;

namespace Tumbleweed.Memory.Span.ReadOnly;

public interface Any<T>
{
	System::ReadOnlySpan<T> AsSystem { get; }
}