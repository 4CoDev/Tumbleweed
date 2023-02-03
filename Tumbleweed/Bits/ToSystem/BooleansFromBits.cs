using Tumbleweed.Enumerables;

namespace Tumbleweed.Bits.ToSystem;

public sealed class BooleansFromBits : EnumerableEnvelope<bool>
{
	public BooleansFromBits(IEnumerable<IBit> bits) : base
	(
		new SelectedByExpression<IBit, bool>(
			bits,
			bit => bit.State)
	)
	{
	}
}