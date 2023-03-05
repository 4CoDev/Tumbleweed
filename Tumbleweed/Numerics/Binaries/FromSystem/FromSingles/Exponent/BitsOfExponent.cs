using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Exponent;

public sealed class BitsOfExponent : EnumerableEnvelope<IBit>
{
	public BitsOfExponent(IScalar<float> single) : base
	(
		new ElementsFromMiddle<IBit>(
			new BitsOfSingle(single), 23, 29)
	)
	{
	}
}