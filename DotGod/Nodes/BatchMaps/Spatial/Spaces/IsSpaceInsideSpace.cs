using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Points.Spatial.Real.Comparison;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

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