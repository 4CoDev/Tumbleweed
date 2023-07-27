using DotGod.Spatial._Node.Batch.Entities;
using DotGod.Spatial._Node.Batch.Result.Of;
using DotGod.Spatial._Node.Batch.Space;

namespace DotGod.Spatial._Node.Batch;

public sealed class Suitable : Envelope
{
	public Suitable
	(
		Spaced.Abstract.IBatch batch,
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
		Spaced.Abstract.IBatch batch,
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
		Spaced.Abstract.IBatch batch,
		ISpace space
	)
	{
		if (!new IsSpaceInsideBatch(batch, space).State)
			throw new InvalidOperationException(
				"The space is not inside the batch.");
		return new SuitableOrInitial(batch, space);
	}
}