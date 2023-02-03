using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromSingles;

public sealed class MantissaSize : ScalarEnvelope<int>
{
	public MantissaSize() : base
	(
		new ScalarOfValue<int>(23)
	)
	{
	}
}