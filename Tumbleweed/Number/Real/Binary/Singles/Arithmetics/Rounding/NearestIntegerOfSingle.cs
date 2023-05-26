using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.Singles.Arithmetics.Rounding;

public sealed class NearestIntegerOfSingle : ScalarEnvelope<Single>
{
	public NearestIntegerOfSingle(IScalar<Single> single) : base
	(
		new ResultOfFunction<Single>(
			() => MathF.Round(single.Value))
	)
	{
	}
}