using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Booleans.FromEnumerable;

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