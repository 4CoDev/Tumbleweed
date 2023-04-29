using TumbleGD.Nodes.BatchMaps.Spatial.Occupation.Points;
using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Numerics.Fractional.Spatial.Comparison;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

public sealed class IsSpaceInsideSpace : BooleanEnvelope
{
	public IsSpaceInsideSpace
	(
		IOccupiedSpace @internal,
		IOccupiedSpace external
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