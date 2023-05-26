using Tumbleweed._Boolean;
using Tumbleweed.Number.Real.Binary.Singles.Comparison;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;

namespace Tumbleweed.Number.Real.Comparison;

public sealed class IsLessThanOrEqualsToFractional : BooleanEnvelope
{
	public IsLessThanOrEqualsToFractional
	(
		IReal first,
		IReal second
	) : base
	(
		new IsLessThanOrEqualsToSingle(
			new SingleFromReal(first),
			new SingleFromReal(second))
	)
	{
	}
}