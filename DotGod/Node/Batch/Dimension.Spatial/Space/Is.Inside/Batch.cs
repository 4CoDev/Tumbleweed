namespace DotGod.Node.Batch.Dimension.Spatial.Space.Is.Inside;

public sealed class Batch : Tumbleweed.Boolean.Envelope
{
	public Batch
	(
		Spaced.Any batch,
		Any space
	) : base
	(
		new Space(
			space,
			new Spaced.Member.Space.One(batch))
	)
	{
	}
}