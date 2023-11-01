using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Memory.Span.ReadOnly.From.Array;

public sealed class System<T> : ReadOnlySpan.Envelope<T>
{
	public System(T[] array) : this
	(
		new Value<T[]>(array)
	)
	{
	}
	
	public System(Property.Output.Any<T[]> array) : base
	(
		new ReadOnlySpan.System.Function.Result<T>(
			() => new ReadOnlySpan<T>(array.Value))
	)
	{
	}
}