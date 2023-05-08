using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class SpaceFromSize : ISpace
{
	public SpaceFromSize(ISpatial<IReal> size) =>
		half = new QuotientByReal(size, 2);

	public ISpatial<IReal> From =>
		new NegativeSpatial(half);
	
	public ISpatial<IReal> To => half;

	private readonly ISpatial<IReal> half;
}