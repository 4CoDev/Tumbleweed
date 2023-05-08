using Tumbleweed.Enumerables;

namespace Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

public sealed class SinglesFromReals : EnumerableEnvelope<Single>
{
	public SinglesFromReals(IEnumerable<IReal> decimals) : base
	(
		new SelectedByExpression<IReal, Single>(
			decimals,
			@decimal => new SingleFromReal(@decimal).Value)
	)
	{
	}

}