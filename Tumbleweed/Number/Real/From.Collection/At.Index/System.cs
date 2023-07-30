using Tumbleweed.Number.Real.Function;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

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
		new global::Tumbleweed.Scalar.Immutable.With.Value<Int32>(index)
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