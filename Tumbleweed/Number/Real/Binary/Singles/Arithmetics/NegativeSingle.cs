using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.Singles.Arithmetics;

public sealed class NegativeSingle : ScalarEnvelope<Single>
{
	public NegativeSingle(IScalar<Single> single) : base
	(
		new ResultOfFunction<Single>(
			() => -single.Value)
	)
	{
	}
}