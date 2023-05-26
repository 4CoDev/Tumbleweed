using Tumbleweed._Boolean;
using Tumbleweed.Number.Real.Binary.Singles.Comparison;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;

namespace Tumbleweed.Number.Real.Comparison;

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