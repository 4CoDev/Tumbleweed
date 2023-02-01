using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bits.FromSystem;

public sealed class BitsFromBooleans : EnumerableEnvelope<IBit>
{
	public BitsFromBooleans(IEnumerable<IScalar<bool>> booleans) : base
	(
		new SelectedByExpression<IScalar<bool>, IBit>
		(
			booleans,
			boolean => new BitFromBoolean(boolean)
		)
	)
	{
	}
}