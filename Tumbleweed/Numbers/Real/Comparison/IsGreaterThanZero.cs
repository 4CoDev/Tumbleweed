using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Comparison;

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