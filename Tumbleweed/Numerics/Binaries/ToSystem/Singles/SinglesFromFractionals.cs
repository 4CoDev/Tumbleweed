using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Fractional;

namespace Tumbleweed.Numerics.Binaries.ToSystem.Singles;

public sealed class SinglesFromFractionals : EnumerableEnvelope<Single>
{
	public SinglesFromFractionals(IEnumerable<IFractional> decimals) : base
	(
		new SelectedByExpression<IFractional, Single>(
			decimals,
			@decimal => new SingleFromFractional(@decimal).Value)
	)
	{
	}

}