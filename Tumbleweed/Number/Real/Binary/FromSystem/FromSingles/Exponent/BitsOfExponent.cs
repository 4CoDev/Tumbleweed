using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Exponent;

public sealed class BitsOfExponent : EnumerableEnvelope<IBoolean>
{
	public BitsOfExponent(IScalar<Single> single) : base
	(
		new ElementsFromMiddle<IBoolean>(
			new BitsOfSingle(single), 23, 29)
	)
	{
	}
}