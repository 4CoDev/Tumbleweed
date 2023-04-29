using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Booleans.FromSystem;

public sealed class BooleansFromSystem : EnumerableEnvelope<IBoolean>
{
	public BooleansFromSystem(IEnumerable<Boolean> booleans) : base
	(
		new SelectedByExpression<Boolean, IBoolean>
		(
			booleans,
			boolean => new BooleanFromSystem(boolean)
		)
	)
	{
	}
}