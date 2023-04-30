using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromSingles.Mantissa;

public sealed class BitsOfMantissa : EnumerableEnvelope<IBoolean>
{
	public BitsOfMantissa(IScalar<Single> single) : base
	(
		new ElementsFromLeft<IBoolean>(
			new BitsOfSingle(single),
			new MantissaSize())
	)
	{
	}
}