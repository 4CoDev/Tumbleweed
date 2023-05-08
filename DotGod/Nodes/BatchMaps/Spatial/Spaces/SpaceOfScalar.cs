using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class SpaceOfScalar : ISpace
{
	public SpaceOfScalar(IScalar<ISpace> scalar) =>
		this.scalar = scalar;

	public ISpatial<IReal> From =>
		scalar.Value.From;

	public ISpatial<IReal> To =>
		scalar.Value.To;
	
	private readonly IScalar<ISpace> scalar;
}