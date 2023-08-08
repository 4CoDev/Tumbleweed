using DotGod.Node.Spatial.Batch.Space.Octants.Points;
using DotGod.Node.Spatial.Spaced.Abstract;
using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Spatial.Batch.Space.Octants;

public sealed class OctantWithIndex : SpaceEnvelope
{
	public OctantWithIndex
	(
		IBatch batch,
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