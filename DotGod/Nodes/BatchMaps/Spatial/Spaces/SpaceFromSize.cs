using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class SpaceFromSize : ISpace
{
	public SpaceFromSize(IPoint<IReal> size) =>
		half = new QuotientByReal(size, 2);

	public IPoint<IReal> From =>
		new NegativePoint(half);
	
	public IPoint<IReal> To => half;

	private readonly IPoint<IReal> half;
}