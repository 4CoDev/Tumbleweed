using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numbers.Integers.Natural.FromEnumerable;

public sealed class SingleOfEnumerable : NaturalEnvelope
{
	public SingleOfEnumerable
	(
		IEnumerable<INatural> enumerable
	) : base
	(
		new NaturalOfScalar(
			new SingleOfEnumerable<INatural>(
				enumerable))
	)
	{
	}
}