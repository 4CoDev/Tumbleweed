using Tumbleweed.Number.Natural.Point.Spatial.From;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Rounding;
using Actual = DotGod.Node.Batch.Dimension.Spatial.Space.Point.A.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Octant.Collided.By.Point.Index;

public sealed class One : Envelope<Tumbleweed.Number.Natural.Any>
{
	public One
	(
		Spaced.Any batch,
		Any<Tumbleweed.Number.Real.Any> point
	) : this
	(
		new Spaced.Member.Space.One(batch),
		point
	)
	{
	}
	
	public One
	(
		Any space,
		Any<Tumbleweed.Number.Real.Any> point
	) : this
	(
		new Size.Whole.One(space),
		new DifferenceOfPoints(
			point,
			new Actual(space))
	)
	{
	}

	public One
	(
		Any<Tumbleweed.Number.Real.Any> size,
		Any<Tumbleweed.Number.Real.Any> point
	) : base
	(
		new Real(
			new NearestIntegerOfPoint(
				new QuotientOfPoints(point, size)))
	)
	{
	}
}