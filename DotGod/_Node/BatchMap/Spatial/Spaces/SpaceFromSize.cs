using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Real.Arithmetic;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

public sealed class SpaceFromSize : ISpace
{
	public SpaceFromSize(IPoint<IReal> size) =>
		half = new QuotientByReal(size, 2);

	public IPoint<IReal> From =>
		new NegativePoint(half);
	
	public IPoint<IReal> To => half;

	private readonly IPoint<IReal> half;
}