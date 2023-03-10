using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Mantissa;

public sealed class MantissaSize : ScalarEnvelope<Int32>
{
	public MantissaSize() : base
	(
		new ScalarOfValue<Int32>(23)
	)
	{
	}
}