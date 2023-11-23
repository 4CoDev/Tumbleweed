using Tumbleweed.Array.Linear.System.With.Values;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Memory.Span.ReadOnly.From;

public sealed class Enumerable<T> : Envelope<T>
{
	public Enumerable(IEnumerable<T> enumerable) : base
	(
		new ReadOnlySpan.From.Array.System<T>(
			new Tumbleweed.Array.Linear.System.With.Values.From.Enumerable<T>(enumerable))
	)
	{
	}
}