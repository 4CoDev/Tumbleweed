namespace DotGod.Node.Batch.Dimension.Spatial.Spaced.From.Unspaced.With.Space;

public sealed class One : Node.Batch.Dimension.Spatial.Spaced.Envelope
{
	public One
	(
		Node.Batch.Dimension.Spatial.Unspaced.Any batch,
		Spatial.Space.Any space
	) : base
	(
		new DotGod.Node.Batch.Dimension.Spatial.Spaced.With.Members.One
		(
			new Spatial.Unspaced.Subbatch.Array.One(batch),
			new Entity.Collection.One(batch),
			space
		)
	)
	{
	}
}