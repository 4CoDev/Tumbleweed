using Tumbleweed.Scalar.Function;

namespace Tumbleweed.Scalar.From.Enumerable.At.Index;

public sealed class System<T> : Scalar.Envelope<T>
{
	public System
	(
		IEnumerable<T> enumerable,
		Int32 index
	) : this
	(
		enumerable,
		new Scalar.Of.Value<Int32>(index)
	)
	{
	}
	
	public System
	(
		IEnumerable<T> enumerable,
		Scalar.Any<Int32> index
	) : base
	(
		new Function.Result<T>(
			() => enumerable.ElementAt(index.Value))
	)
	{
	}
}