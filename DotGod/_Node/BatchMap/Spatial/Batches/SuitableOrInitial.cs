using DotGod._Node.BatchMap.Spatial.Batches.Spaced;
using DotGod._Node.BatchMap.Spatial.Entities;
using DotGod._Node.BatchMap.Spatial.Spaces;
using DotGod._Node.BatchMap.Spatial.Spaces.Points;

namespace DotGod._Node.BatchMap.Spatial.Batches;

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