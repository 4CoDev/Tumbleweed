namespace Tumbleweed.Numerics.Integers.Natural.FromEnumerable;

public sealed class SingleElementOfEnumerable : NaturalEnvelope
{
	public SingleElementOfEnumerable
	(
		IEnumerable<INaturalInteger> enumerable
	) : base
	(
		new NaturalOfScalar(
			new Scalars.FromEnumerable.SingleElementOfEnumerable<INaturalInteger>(
				enumerable))
	)
	{
	}
}