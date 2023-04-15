using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Integers.Natural.FromEnumerable;

public sealed class SingleOfEnumerable : NaturalEnvelope
{
	public SingleOfEnumerable
	(
		IEnumerable<INaturalInteger> enumerable
	) : base
	(
		new NaturalOfScalar(
			new SingleOfEnumerable<INaturalInteger>(
				enumerable))
	)
	{
	}
}