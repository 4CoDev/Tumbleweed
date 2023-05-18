using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

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