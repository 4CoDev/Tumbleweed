using Tumbleweed._Boolean;
using Tumbleweed.Number.Real.Binary.Singles.Comparison;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;

namespace Tumbleweed.Number.Real.Comparison;

public sealed class IsLessThanFractional : BooleanEnvelope
{
	public IsLessThanFractional
	(
		IReal first,
		IReal second
	) : base
	(
		new IsLessThanSingle(
			new SingleFromReal(first),
			new SingleFromReal(second))
	)
	{
	}
}