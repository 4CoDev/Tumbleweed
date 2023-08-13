using DotGod.Node.Batch.Dimension.Spatial.Spaced;
using Actual = DotGod.Node.Batch.Dimension.Spatial.Space.Point.A.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced.Have.Subbatch.Collided.By.Space.Point.A;

public sealed class One : Tumbleweed.Boolean.Envelope
{
	public One
	(
		Spaced.Any batch,
		Spatial.Space.Any space
	) : base
	(
		new Collided.By.Point.One(
			batch,
			new Actual(space))
	)
	{
	}
}