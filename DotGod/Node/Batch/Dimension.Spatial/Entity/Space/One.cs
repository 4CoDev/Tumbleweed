namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Space;

public sealed class One : Spatial.Space.Envelope
{
	public One(Any entity) : base
	(
		new Spatial.Space.Function.Result.One(
			() => entity.Occupation)
	)
	{
	}
}