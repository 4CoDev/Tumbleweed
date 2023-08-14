namespace DotGod.Node.Batch.Dimension.Spatial.Unmeasured.Array.Item.Value.At.Index;

public sealed class One : Envelope
{
	public One
	(Tumbleweed.Array.Any<Any> array, Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Natural.Any> indices
	) : base
	(
		new Scalar.Value.One(
			new Tumbleweed.Scalar.Immutable.From.Array.Spatial.At.Index<Any>(
				array, 
				indices))
	)
	{
	}
}