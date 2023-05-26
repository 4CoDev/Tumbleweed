using Tumbleweed._Boolean;
using Tumbleweed.Number.Real.Binary.Singles.Comparison;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;

namespace Tumbleweed.Number.Real.Comparison;

public sealed class IsEqualsToFractional : BooleanEnvelope
{
	public IsEqualsToFractional
	(
		IReal first,
		IReal second
	) : base
	(
		new IsEqualsToSingle(
			new SingleFromReal(first),
			new SingleFromReal(second))
	)
	{
	}
}