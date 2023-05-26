using Tumbleweed._Enumerable;

namespace Tumbleweed.Number.Real.Binary.ToSystem.Singles;

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