using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Binaries.Singles.Comparison;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

namespace Tumbleweed.Numbers.Real.Comparison;

public sealed class IsEqualsToFractional : BooleanEnvelope
{
	public IsEqualsToFractional
	(
		IReal first,
		IReal second
	) : base
	(
		new IsEqualsToSingle(
			new SingleFromFractional(first),
			new SingleFromFractional(second))
	)
	{
	}
}