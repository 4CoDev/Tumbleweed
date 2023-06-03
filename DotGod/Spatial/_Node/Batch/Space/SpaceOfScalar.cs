using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class SpaceOfScalar : ISpace
{
	public SpaceOfScalar(IScalar<ISpace> scalar) =>
		this.scalar = scalar;

	public IPoint<IReal> From =>
		scalar.Value.From;

	public IPoint<IReal> To =>
		scalar.Value.To;
	
	private readonly IScalar<ISpace> scalar;
}