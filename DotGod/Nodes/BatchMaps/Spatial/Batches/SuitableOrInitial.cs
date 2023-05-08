using DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;
using DotGod.Nodes.BatchMaps.Spatial.Entities;
using DotGod.Nodes.BatchMaps.Spatial.Spaces;
using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

public sealed class SuitableOrInitial : BatchEnvelope
{
	public SuitableOrInitial
	(
		ISpacedBatch initial,
		ISpatialEntity entity
	) : this
	(
		initial,
		new SpaceOfEntity(entity)
	)
	{
	}
	
	public SuitableOrInitial
	(
		ISpacedBatch initial,
		ISpace space
	) : base
	(
		new BatchOfFunction(
			() => Function(initial, space))
	)
	{
	}

	private static IBatch Function
	(
		ISpacedBatch initial,
		ISpace space
	)
	{
		ISpacedBatch subbatch =
			new SubbatchWithPoint(initial, new FromPointOfSpace(space));
		if (!new IsSpaceInsideBatch(subbatch, space).State) return initial;
		if (new IsLeafBatch(subbatch).State) return subbatch;
		return new SuitableOrInitial(subbatch, space);
	}
}