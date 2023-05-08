using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Natural.OfSystem;

public sealed class Int32FromSingle : ScalarEnvelope<Int32>
{
	public Int32FromSingle(Single single) : this
	(
		new ScalarValue<Single>(single)
	)
	{
	}
	
	public Int32FromSingle(IScalar<Single> single) : base
	(
		new ValueOfFunction<Int32>(
			() => (Int32) single.Value)
	)
	{
	}
}