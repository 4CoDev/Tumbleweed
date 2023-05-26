using Tumbleweed.Scalar.FromEnumerable;

namespace Tumbleweed.Number.Integer.Signed.FromEnumerable;

public sealed class SingleOfEnumerable : SignedEnvelope
{
	public SingleOfEnumerable
	(
		IEnumerable<ISigned> enumerable
	) : base
	(
		new SignedOfScalar(
			new SingleOfEnumerable<ISigned>(enumerable))
	)
	{
	}
}