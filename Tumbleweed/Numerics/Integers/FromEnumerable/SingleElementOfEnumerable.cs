namespace Tumbleweed.Numerics.Integers.FromEnumerable;

public sealed class SingleElementOfEnumerable : IntegerEnvelope
{
	public SingleElementOfEnumerable(IEnumerable<IInteger> enumerable) : base
	(
		new IntegerOfScalar(
			new Scalars.FromEnumerable
				.SingleElementOfEnumerable<IInteger>(enumerable))
	)
	{
	}
}