using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromSystem;

public sealed class BitsFromBooleans : EnumerableEnvelope<IBit>
{
	public BitsFromBooleans(IEnumerable<IScalar<Boolean>> booleans) : base
	(
		new SelectedByExpression<IScalar<Boolean>, IBit>
		(
			booleans,
			boolean => new BitFromBoolean(boolean)
		)
	)
	{
	}
}