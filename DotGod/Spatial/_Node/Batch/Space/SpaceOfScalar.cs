using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class SpaceOfScalar : ISpace
{
	public SpaceOfScalar(Tumbleweed.Scalar.Any<ISpace> any) =>
		this.any = any;

	public Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Real.Any> From =>
		any.Value.From;

	public Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Real.Any> To =>
		any.Value.To;
	
	private readonly Tumbleweed.Scalar.Any<ISpace> any;
}