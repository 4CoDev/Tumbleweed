using DotGod.Spatial._Node.Batch.Entities;
using DotGod.Spatial._Node.Batch.Spaces;
using DotGod.Spatial._Node.Spaced.Batch;

namespace DotGod.Spatial._Node.Batch;

public sealed class SuitableBatch : BatchEnvelope
{
	public SuitableBatch
	(
		ISpacedBatch batch,
		ISpatialEntity entity
	) : this
	(
		batch,
		new SpaceOfEntity(entity)
	)
	{
	}
	
	public SuitableBatch
	(
		ISpacedBatch batch,
		ISpace space
	) : base
	(
		new BatchOfFunction(
			() => Function(batch, space))
	)
	{
	}

	private static IBatch Function
	(
		ISpacedBatch batch,
		ISpace space
	)
	{
		if (!new IsSpaceInsideBatch(batch, space).State)
			throw new InvalidOperationException(
				"The space is not inside the batch.");
		if (new IsLeafBatch(batch).State) return batch;
		return new SuitableOrInitial(batch, space);
	}
}