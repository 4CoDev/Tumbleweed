using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Memory.Span.ReadOnly.From.Array;

public sealed class System<T> : ReadOnlySpan.Envelope<T>
{
	public System(T[] array) : this
	(
		new Scalar.Of.Value<T[]>(array)
	)
	{
	}
	
	public System(Scalar.Any<T[]> array) : base
	(
		new ReadOnlySpan.System.Function.Result<T>(
			() => new ReadOnlySpan<T>(array.Value))
	)
	{
	}
}