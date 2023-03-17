using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Integers.Natural.FromEnumerable;

public sealed class SingleElementOfEnumerable : NaturalEnvelope
{
	public SingleElementOfEnumerable
	(
		IEnumerable<INaturalInteger> enumerable
	) : base
	(
		new NaturalOfScalar(
			new SingleElementOfEnumerable<INaturalInteger>(
				enumerable))
	)
	{
	}
}