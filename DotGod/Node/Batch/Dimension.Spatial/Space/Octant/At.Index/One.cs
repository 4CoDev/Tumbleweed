using DotGod.Node.Batch.Dimension.Spatial.Space.Octant.At.Index.Point;
using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Octant.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Spaced.Any batch,
		Any<Tumbleweed.Number.Natural.Any> index) : this
	(
		new Spaced.Member.Space.One(batch),
		index
	)
	{
	}
	
	public One
	(
		Any space,
		Any<Tumbleweed.Number.Natural.Any> index) : base
	(
		new With.Points.One(
			new A(space, index),
			new B(space, index))
	)
	{
	}
}