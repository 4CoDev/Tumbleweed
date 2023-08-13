namespace DotGod.Node.Batch.Dimension.Spatial.Spaced.Member.Space;

public sealed class One : Spatial.Space.Envelope
{
	public One(Any batch) : base
	(
		new Spatial.Space.Function.Result.One(
			() => batch.Space)
	)
	{
	}
}