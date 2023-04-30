using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numbers.Integers.Signed.FromEnumerable;

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