using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Integers.Signed.FromEnumerable;

public sealed class SingleOfEnumerable : SignedEnvelope
{
	public SingleOfEnumerable
	(
		IEnumerable<ISignedInteger> enumerable
	) : base
	(
		new SignedOfScalar(
			new SingleOfEnumerable<ISignedInteger>(enumerable))
	)
	{
	}
}