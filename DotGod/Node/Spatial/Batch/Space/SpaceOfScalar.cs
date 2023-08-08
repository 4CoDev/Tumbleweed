namespace DotGod.Node.Spatial.Batch.Space;

public sealed class SpaceOfScalar : ISpace
{
	public SpaceOfScalar(Tumbleweed.Scalar.Immutable.Any<ISpace> any) =>
		this.any = any;

	public Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Real.Any> From =>
		any.Value.From;

	public Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Real.Any> To =>
		any.Value.To;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<ISpace> any;
}