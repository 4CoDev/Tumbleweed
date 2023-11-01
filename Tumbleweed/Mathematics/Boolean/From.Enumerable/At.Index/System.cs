using Tumbleweed.Mathematics.Boolean.Function.Result;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;
using Boolean = Tumbleweed.Mathematics.Boolean;
using Collection = Tumbleweed.Collection;

namespace Tumbleweed.Mathematics.Boolean.From.Enumerable.At.Index;

public sealed class System : Boolean::Envelope
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
		new Boolean::Property.Value.Actual(
			new Collection::Item.At.Index.System.One
				<Boolean::Any>
				(bits, index))
	)
	{
	}
}