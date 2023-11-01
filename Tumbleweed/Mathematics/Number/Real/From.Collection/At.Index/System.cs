using Tumbleweed.Mathematics.Number.Real.Function;
using Tumbleweed.Property.Output;

namespace Tumbleweed.Mathematics.Number.Real.From.Collection.At.Index;

public sealed class System : Envelope
{
	public System
	(
		ICollection<Any> decimals,
		Int32 index
	) : this
	(
		decimals,
		new global::Tumbleweed.Property.Output.With.Value<Int32>(index)
	)
	{
	}
	
	public System
	(
		ICollection<Any> decimals,
		Any<Int32> index
	) : base
	(
		new Function.Result.Actual(
			() => decimals.ElementAt(index.Value))
	)
	{
	}
}