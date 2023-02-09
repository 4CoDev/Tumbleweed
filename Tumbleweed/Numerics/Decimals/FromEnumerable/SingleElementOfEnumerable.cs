namespace Tumbleweed.Numerics.Decimals.FromEnumerable;

public sealed class SingleElementOfEnumerable : DecimalEnvelope
{
	public SingleElementOfEnumerable(IEnumerable<IDecimal> enumerable) : base
	(
		new DecimalOfScalar(
			new Scalars.FromEnumerable
				.SingleElementOfEnumerable<IDecimal>(enumerable))
	)
	{
	}
}