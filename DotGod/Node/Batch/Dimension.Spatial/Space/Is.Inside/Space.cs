using Tumbleweed.Boolean.Comparison.Both.Are;
using Tumbleweed.Point.Spatial.Real.Comparison;
using Actual = DotGod.Node.Batch.Dimension.Spatial.Space.Point.B.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Is.Inside;

public sealed class Space : Tumbleweed.Boolean.Envelope
{
	public Space
	(
		Any @internal,
		Any external
	) : base
	(
		new True(
			new IsGreaterThanOrEqualsToPoint(
				new Point.A.Actual(@internal),
				new Point.A.Actual(external)),
			new IsLessThanOrEqualsToPoint(
				new Actual(@internal),
				new Actual(external)))
	)
	{
	}
}