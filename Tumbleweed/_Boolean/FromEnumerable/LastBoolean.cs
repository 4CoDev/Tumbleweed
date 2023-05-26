using Tumbleweed.Scalar.FromEnumerable;

namespace Tumbleweed._Boolean.FromEnumerable;

public sealed class LastBoolean : BooleanEnvelope
{
	public LastBoolean(IEnumerable<IBoolean> enumerable) : base
	(
		new BooleanOfScalar(
			new LastOfEnumerable<IBoolean>(enumerable))
	)
	{
	}
}