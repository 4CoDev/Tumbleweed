using DotGod.Spatial._Node.Batch.Space.Points;
using Tumbleweed.Boolean;
using Tumbleweed.Boolean.Comparison.Both.Are;
using Tumbleweed.Point.Spatial.Real.Comparison;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class IsSpaceInsideSpace : Tumbleweed.Boolean.Envelope
{
	public IsSpaceInsideSpace
	(
		ISpace @internal,
		ISpace external
	) : base
	(
		new True(
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