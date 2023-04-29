using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public sealed class SpaceOfScalar : IOccupiedSpace
{
	public SpaceOfScalar(IScalar<IOccupiedSpace> scalar) =>
		this.scalar = scalar;

	public ISpatial<IFractional> From =>
		scalar.Value.From;

	public ISpatial<IFractional> To =>
		scalar.Value.To;
	
	private readonly IScalar<IOccupiedSpace> scalar;
}