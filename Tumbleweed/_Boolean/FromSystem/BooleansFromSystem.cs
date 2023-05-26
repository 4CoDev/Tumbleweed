using Tumbleweed._Enumerable;

namespace Tumbleweed._Boolean.FromSystem;

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