using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Mantissa;

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