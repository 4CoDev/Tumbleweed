using DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;
using DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants.Points;
using Tumbleweed.Points.Spatial;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants;

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