using Tumbleweed.Number.Real.Function;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.From.Collection.At.Index;

public sealed class System : Envelope
{
	public System
	(
		ICollection<Any> decimals,
		Int32 index
	) : this
	(
		decimals,
		new global::Tumbleweed.Scalar.Of.Value<Int32>(index)
	)
	{
	}
	
	public System
	(
		ICollection<Any> decimals,
		Any<Int32> index
	) : base
	(
		new Result(
			() => decimals.ElementAt(index.Value))
	)
	{
	}
}