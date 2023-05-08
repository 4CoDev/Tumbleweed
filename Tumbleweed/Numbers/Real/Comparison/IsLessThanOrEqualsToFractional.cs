using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Binaries.Singles.Comparison;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

namespace Tumbleweed.Numbers.Real.Comparison;

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