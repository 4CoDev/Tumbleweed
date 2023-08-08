using DotGod.Node.Spatial.Batch.Entities;
using DotGod.Node.Spatial.Batch.Space;
using DotGod.Node.Spatial.Spaced.Abstract;
using DotGod.Spatial._Node.Batch.Result.Of;

namespace DotGod.Node.Spatial.Batch;

public sealed class Suitable : Envelope
{
	public Suitable
	(
		IBatch batch,
		ISpatialEntity entity
	) : this
	(
		batch,
		new SpaceOfEntity(entity)
	)
	{
	}
	
	public Suitable
	(
		IBatch batch,
		ISpace space
	) : base
	(
		new Function(
			() => Function(batch, space))
	)
	{
	}

	private static Any Function
	(
		IBatch batch,
		ISpace space
	)
	{
		if (!new IsSpaceInsideBatch(batch, space).State)
			throw new InvalidOperationException(
				"The space is not inside the batch.");
		return new SuitableOrInitial(batch, space);
	}
}