using DotGod._Node.BatchMap.Spatial.Spaces.Points;
using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Spatial.Point.Real.Comparison;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

public sealed class IsSpaceInsideSpace : BooleanEnvelope
{
	public IsSpaceInsideSpace
	(
		ISpace @internal,
		ISpace external
	) : base
	(
		new AndOfTwoBooleans(
			new IsGreaterThanOrEqualsToPoint(
				new FromPointOfSpace(@internal),
				new FromPointOfSpace(external)),
			new IsLessThanOrEqualsToPoint(
				new ToPointOfSpace(@internal),
				new ToPointOfSpace(external)))
	)
	{
	}
}