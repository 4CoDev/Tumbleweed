using Tumbleweed.Scalar.FromEnumerable;

namespace Tumbleweed.Number.Integer.Natural.FromEnumerable;

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