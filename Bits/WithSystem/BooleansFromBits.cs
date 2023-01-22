using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.WithSystem;

public sealed class BooleansFromBits : EnumerableEnvelope<IScalar<bool>>
{
	public BooleansFromBits(IEnumerable<IBit> bits) : base
	(
		new SelectedByExpression<IBit, IScalar<bool>>(
			bits,
			bit => bit.State)
	)
	{
	}
}