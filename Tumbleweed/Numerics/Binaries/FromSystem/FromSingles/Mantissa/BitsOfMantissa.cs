using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Mantissa;

public sealed class BitsOfMantissa : EnumerableEnvelope<IBit>
{
	public BitsOfMantissa(IScalar<Single> single) : base
	(
		new ElementsFromLeft<IBit>(
			new BitsOfSingle(single),
			new MantissaSize())
	)
	{
	}
}