using DotGod.Spatial._Node.Batch.Entities;
using DotGod.Spatial._Node.Batch.Spaces;
using DotGod.Spatial._Node.Batch.Spaces.Points;
using DotGod.Spatial._Node.Spaced.Batch;

namespace DotGod.Spatial._Node.Batch;

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