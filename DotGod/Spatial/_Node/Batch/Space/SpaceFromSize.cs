using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class SpaceFromSize : ISpace
{
	public SpaceFromSize(Any<Tumbleweed.Number.Real.Any> size) =>
		half = new QuotientByReal(size, 2);

	public Any<Tumbleweed.Number.Real.Any> From =>
		new NegativePoint(half);
	
	public Any<Tumbleweed.Number.Real.Any> To => half;

	private readonly Any<Tumbleweed.Number.Real.Any> half;
}