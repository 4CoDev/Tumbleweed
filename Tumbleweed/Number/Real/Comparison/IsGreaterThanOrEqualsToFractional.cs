using Tumbleweed._Boolean;
using Tumbleweed.Number.Real.Binary.Singles.Comparison;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;

namespace Tumbleweed.Number.Real.Comparison;

public sealed class IsGreaterThanOrEqualsToFractional : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToFractional
	(
		IReal first,
		IReal second
	) : base
	(
		new IsGreaterThanOrEqualsToSingle(
			new SingleFromReal(first),
			new SingleFromReal(second))
	)
	{
	}
}