using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.From.Enumerable.At.Index;

public sealed class System : Envelope
{
	public System
	(
		IEnumerable<Any> decimals,
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
		IEnumerable<Any> decimals,
		Any<Int32> index
	) : base
	(
		new Collection.At.Index.System(
			new List<Any>(decimals),
			index)
	)
	{
	}

}