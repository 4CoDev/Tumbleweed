using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.Binaries.Singles.Comparison;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

namespace Tumbleweed.Numbers.Real.Comparison;

public sealed class IsGreaterThanFractional : BooleanEnvelope
{
	public IsGreaterThanFractional
	(
		IReal first,
		IReal second
	) : base
	(
		new IsGreaterThanSingle(
			new SingleFromReal(first),
			new SingleFromReal(second))
	)
	{
	}
}