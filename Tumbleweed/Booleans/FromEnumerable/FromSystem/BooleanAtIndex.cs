using Tumbleweed.Scalars;

namespace Tumbleweed.Booleans.FromEnumerable.FromSystem;

public sealed class BooleanAtIndex : BooleanEnvelope
{
	public BooleanAtIndex(IEnumerable<IBoolean> bits, Int32 index) : this
	(
		new List<IBoolean>(bits), new ScalarValue<Int32>(index)
	)
	{
	}
	
	public BooleanAtIndex(IEnumerable<IBoolean> bits, IScalar<Int32> index) : this
	(
		new List<IBoolean>(bits), index
	)
	{
	}
	
	public BooleanAtIndex(ICollection<IBoolean> bits, Int32 index) : this
	(
		bits, new ScalarValue<Int32>(index)
	)
	{
	}
	
	public BooleanAtIndex(ICollection<IBoolean> bits, IScalar<Int32> index) : base
	(
		new BooleanOfFunction(
			() => bits.ElementAt(index.Value))
	)
	{
	}
}