using DotGod.Spatial._Node.Batch.Space.Octants.Points;
using DotGod.Spatial._Node.Spaced.Batch;
using Tumbleweed.Spatial.Point;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;

namespace DotGod.Spatial._Node.Batch.Space.Octants;

public sealed class OctantWithIndex : SpaceEnvelope
{
	public OctantWithIndex
	(
		ISpacedBatch batch,
		IPoint<INaturalNumber> index) : this
	(
		new SpaceOfBatch(batch),
		index
	)
	{
	}
	
	public OctantWithIndex
	(
		ISpace space,
		IPoint<INaturalNumber> index) : base
	(
		new SpaceWithPoints(
			new FromPointWithIndex(space, index),
			new ToPointWithIndex(space, index))
	)
	{
	}
}