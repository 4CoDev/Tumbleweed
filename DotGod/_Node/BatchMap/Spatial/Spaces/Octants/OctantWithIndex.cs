using DotGod._Node.BatchMap.Spatial.Batches.Spaced;
using DotGod._Node.BatchMap.Spatial.Spaces.Octants.Points;
using Tumbleweed.Spatial.Point;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;

namespace DotGod._Node.BatchMap.Spatial.Spaces.Octants;

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