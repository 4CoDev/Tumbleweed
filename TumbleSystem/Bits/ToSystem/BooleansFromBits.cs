using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bits.ToSystem;

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