using Actual = DotGod.Node.Batch.Dimension.Spatial.Space.Point.A.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Spaced.Subbatch.NonNullable.Collided.By.Space.Point.A;

public sealed class One : Envelope
{
	public One(Any batch, Spatial.Space.Any space) : base
	(
		new Node.Batch.Dimension.Spatial.Spaced.Subbatch.NonNullable.Collided.By.Point.One(
			batch,
			new Actual(space))
	)
	{
	}
}