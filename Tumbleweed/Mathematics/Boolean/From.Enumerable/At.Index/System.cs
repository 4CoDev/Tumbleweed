using Tumbleweed.Boolean.Function;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace Tumbleweed.Mathematics.Boolean.From.Enumerable.At.Index;

public sealed class System : Envelope
{
	public System(IEnumerable<Any> bits, Int32 index) : this
	(
		new List<Any>(bits), new Value<Int32>(index)
	)
	{
	}
	
	public System(IEnumerable<Any> bits, Any<Int32> index) : this
	(
		new List<Any>(bits), index
	)
	{
	}
	
	public System(ICollection<Any> bits, Int32 index) : this
	(
		bits, new Value<Int32>(index)
	)
	{
	}
	
	public System(ICollection<Any> bits, Any<Int32> index) : base
	(
		new Result(
			() => bits.ElementAt(index.Value))
	)
	{
	}
}