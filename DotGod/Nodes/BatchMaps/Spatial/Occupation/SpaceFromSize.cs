using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public sealed class SpaceFromSize : IOccupiedSpace
{
	public SpaceFromSize(ISpatial<IReal> size) =>
		half = new QuotientByFractional(size, 2);

	public ISpatial<IReal> From =>
		new NegativeSpatial(half);
	
	public ISpatial<IReal> To => half;

	private readonly ISpatial<IReal> half;
}