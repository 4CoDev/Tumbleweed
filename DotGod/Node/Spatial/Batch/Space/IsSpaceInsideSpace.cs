using DotGod.Node.Spatial.Batch.Space.Points;
using Tumbleweed.Boolean.Comparison.Both.Are;
using Tumbleweed.Point.Spatial.Real.Comparison;

namespace DotGod.Node.Spatial.Batch.Space;

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