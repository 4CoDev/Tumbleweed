using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public sealed class SpaceOfScalar : IOccupiedSpace
{
	public SpaceOfScalar(IScalar<IOccupiedSpace> scalar) =>
		this.scalar = scalar;

	public ISpatial<IReal> From =>
		scalar.Value.From;

	public ISpatial<IReal> To =>
		scalar.Value.To;
	
	private readonly IScalar<IOccupiedSpace> scalar;
}