using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Mantissa;

public sealed class MantissaSize : ScalarEnvelope<int>
{
	public MantissaSize() : base
	(
		new ScalarOfValue<int>(23)
	)
	{
	}
}