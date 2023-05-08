using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Binaries.Singles.Comparison;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

namespace Tumbleweed.Numbers.Real.Comparison;

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