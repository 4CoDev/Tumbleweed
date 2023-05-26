using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.OfSystem.Singles;

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
		new ResultOfFunction<Single>(
			() => integer.Value)
	)
	{
	}
}