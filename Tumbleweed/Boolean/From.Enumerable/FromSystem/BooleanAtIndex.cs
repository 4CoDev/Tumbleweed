using Tumbleweed.Boolean.Function;
using Tumbleweed.Scalar;

namespace Tumbleweed.Boolean.From.Enumerable.FromSystem;

public sealed class BooleanAtIndex : Envelope
{
	public BooleanAtIndex(IEnumerable<Any> bits, Int32 index) : this
	(
		new List<Any>(bits), new Tumbleweed.Scalar.Of.Value<Int32>(index)
	)
	{
	}
	
	public BooleanAtIndex(IEnumerable<Any> bits, Any<Int32> index) : this
	(
		new List<Any>(bits), index
	)
	{
	}
	
	public BooleanAtIndex(ICollection<Any> bits, Int32 index) : this
	(
		bits, new Tumbleweed.Scalar.Of.Value<Int32>(index)
	)
	{
	}
	
	public BooleanAtIndex(ICollection<Any> bits, Any<Int32> index) : base
	(
		new Result(
			() => bits.ElementAt(index.Value))
	)
	{
	}
}