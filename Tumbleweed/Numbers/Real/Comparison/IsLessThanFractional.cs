using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Binaries.Singles.Comparison;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

namespace Tumbleweed.Numbers.Real.Comparison;

public sealed class IsLessThanFractional : BooleanEnvelope
{
	public IsLessThanFractional
	(
		IReal first,
		IReal second
	) : base
	(
		new IsLessThanSingle(
			new SingleFromFractional(first),
			new SingleFromFractional(second))
	)
	{
	}
}