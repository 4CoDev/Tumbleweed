using Tumbleweed._Boolean;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Comparison;

public sealed class IsGreaterThanZero : BooleanEnvelope
{
	public IsGreaterThanZero
	(
		IReal greater
	) : base
	(
		new IsGreaterThanFractional(
			greater,
			new RealFromSingle(0))
	)
	{
	}
}