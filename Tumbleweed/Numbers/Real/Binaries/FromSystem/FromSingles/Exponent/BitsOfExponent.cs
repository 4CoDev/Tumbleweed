using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromSingles.Exponent;

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