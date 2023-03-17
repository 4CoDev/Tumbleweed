using Tumbleweed.Enumerables;

namespace Tumbleweed.Bits.ToSystem;

public sealed class BooleansFromBits : EnumerableEnvelope<Boolean>
{
	public BooleansFromBits(IEnumerable<IBit> bits) : base
	(
		new SelectedByExpression<IBit, Boolean>(
			bits,
			bit => bit.State)
	)
	{
	}
}