using DotGod.Spatial._Node.Batch.Space.Octants.Points;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial._Node.Batch.Space.Octants;

public sealed class OctantWithIndex : SpaceEnvelope
{
	public OctantWithIndex
	(
		Spaced.Abstract.IBatch batch,
		Any<Tumbleweed.Number.Natural.Any> index) : this
	(
		new Spaced.Batch.Space.Of.Batch(batch),
		index
	)
	{
	}
	
	public OctantWithIndex
	(
		ISpace space,
		Any<Tumbleweed.Number.Natural.Any> index) : base
	(
		new SpaceWithPoints(
			new FromPointWithIndex(space, index),
			new ToPointWithIndex(space, index))
	)
	{
	}
}