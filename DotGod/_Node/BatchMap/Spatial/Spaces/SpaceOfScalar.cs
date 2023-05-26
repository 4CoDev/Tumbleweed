using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

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