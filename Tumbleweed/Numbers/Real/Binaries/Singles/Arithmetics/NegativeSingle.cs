using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics;

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