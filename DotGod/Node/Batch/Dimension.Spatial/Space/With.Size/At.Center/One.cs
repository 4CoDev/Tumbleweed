using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.With.Size.At.Center;

public sealed class One : Any
{
	public One(Any<Tumbleweed.Number.Real.Any> size) =>
		half = new QuotientByReal(size, 2);

	public Any<Tumbleweed.Number.Real.Any> A =>
		new NegativePoint(half);
	
	public Any<Tumbleweed.Number.Real.Any> B => half;

	private readonly Any<Tumbleweed.Number.Real.Any> half;
}