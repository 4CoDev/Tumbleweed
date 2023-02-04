using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Decimals;

namespace Tumbleweed.Numerics.Binary.ToSystem.Singles;

public sealed class SinglesFromDecimals : EnumerableEnvelope<float>
{
	public SinglesFromDecimals(IEnumerable<IDecimal> decimals) : base
	(
		new SelectedByExpression<IDecimal, float>(
			decimals,
			@decimal => new SingleFromDecimal(@decimal).Value())
	)
	{
	}

}