namespace Tumbleweed.Numerics.Integers.Signed.FromEnumerable;

public sealed class SingleElementOfEnumerable : SignedEnvelope
{
	public SingleElementOfEnumerable(IEnumerable<ISignedInteger> enumerable) : base
	(
		new SignedOfScalar(
			new Scalars.FromEnumerable
				.SingleElementOfEnumerable<ISignedInteger>(enumerable))
	)
	{
	}
}