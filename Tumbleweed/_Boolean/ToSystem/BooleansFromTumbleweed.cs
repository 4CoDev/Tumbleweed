using Tumbleweed._Enumerable;

namespace Tumbleweed._Boolean.ToSystem;

public sealed class BooleansFromTumbleweed : EnumerableEnvelope<Boolean>
{
	public BooleansFromTumbleweed(IEnumerable<IBoolean> bits) : base
	(
		new SelectedByExpression<IBoolean, Boolean>(
			bits,
			bit => bit.State)
	)
	{
	}
}