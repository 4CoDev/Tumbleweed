using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.OfSystem.Singles;

public sealed class SingleFromInt32 : ScalarEnvelope<Single>
{
	public SingleFromInt32(Int32 integer) : this
	(
		new ScalarValue<Int32>(integer)
	)
	{
	}

	public SingleFromInt32(IScalar<Int32> integer) : base
	(
		new ResultOfFunction<Single>(
			() => integer.Value)
	)
	{
	}
}