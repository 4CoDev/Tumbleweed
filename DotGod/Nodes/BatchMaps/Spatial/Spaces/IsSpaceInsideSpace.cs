using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numbers.Real.Spatial.Comparison;

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
			new IsGreaterThanOrEqualsToSpatial(
				new FromPointOfSpace(@internal),
				new FromPointOfSpace(external)),
			new IsLessThanOrEqualsToSpatial(
				new ToPointOfSpace(@internal),
				new ToPointOfSpace(external)))
	)
	{
	}
}