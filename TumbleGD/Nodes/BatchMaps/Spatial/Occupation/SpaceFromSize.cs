using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.Spatial;
using Tumbleweed.Numerics.Fractional.Spatial.Arithmetics;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

public sealed class SpaceFromSize : IOccupiedSpace
{
	public SpaceFromSize(ISpatial<IFractional> size) =>
		half = new QuotientByFractional(size, 2);

	public ISpatial<IFractional> From =>
		new NegativeSpatial(half);
	
	public ISpatial<IFractional> To => half;

	private readonly ISpatial<IFractional> half;
}