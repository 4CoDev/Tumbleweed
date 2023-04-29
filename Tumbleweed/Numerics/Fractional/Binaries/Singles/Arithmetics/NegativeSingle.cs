using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.Singles.Arithmetics;

public sealed class NegativeSingle : ScalarEnvelope<Single>
{
	public NegativeSingle(IScalar<Single> single) : base
	(
		new ValueOfFunction<Single>(
			() => -single.Value)
	)
	{
	}
}