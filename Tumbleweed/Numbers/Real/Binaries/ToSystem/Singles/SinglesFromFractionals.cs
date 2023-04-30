using Tumbleweed.Enumerables;

namespace Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

public sealed class SinglesFromFractionals : EnumerableEnvelope<Single>
{
	public SinglesFromFractionals(IEnumerable<IReal> decimals) : base
	(
		new SelectedByExpression<IReal, Single>(
			decimals,
			@decimal => new SingleFromFractional(@decimal).Value)
	)
	{
	}

}