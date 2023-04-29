using Tumbleweed.Enumerables;

namespace Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;

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