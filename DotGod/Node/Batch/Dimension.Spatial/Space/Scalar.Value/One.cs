namespace DotGod.Node.Batch.Dimension.Spatial.Space.Scalar.Value;

public sealed class One : Any
{
	public One(Tumbleweed.Scalar.Immutable.Any<Any> any) =>
		this.any = any;

	public Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Real.Any> A =>
		any.Value.A;

	public Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Real.Any> B =>
		any.Value.B;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Any> any;
}