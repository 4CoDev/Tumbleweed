using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics.Rounding;

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