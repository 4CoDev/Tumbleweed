using DotGod.Node.Batch.Dimension.Spatial.Spaced;
using One = DotGod.Node.Batch.Dimension.Spatial.Unspaced.Function.Result.One;

namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced;

public sealed class Suitable : Envelope
{
	public Suitable
	(
		Spaced.Any batch,
		Entity.Any entity
	) : this
	(
		batch,
		new Entity.Space.One(entity)
	)
	{
	}
	
	public Suitable
	(
		Spaced.Any batch,
		Space.Any space
	) : base
	(
		new One(
			() => Function(batch, space))
	)
	{
	}

	private static Any Function
	(
		Spaced.Any batch,
		Space.Any space
	)
	{
		if (!new Space.Is.Inside.Batch(batch, space).State)
			throw new InvalidOperationException(
				"The space is not inside the batch.");
		return new SuitableOrInitial(batch, space);
	}
}