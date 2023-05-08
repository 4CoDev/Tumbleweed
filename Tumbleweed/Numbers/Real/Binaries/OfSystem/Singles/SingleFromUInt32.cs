using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.OfSystem.Singles;

public sealed class SingleFromUInt32 : ScalarEnvelope<Single>
{
	public SingleFromUInt32(UInt32 integer) : this
	(
		new ScalarValue<UInt32>(integer)
	)
	{
	}
	
	public SingleFromUInt32(IScalar<UInt32> integer) : base
	(
		new ValueOfFunction<Single>(
			() => integer.Value)
	)
	{
	}
}