using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;

namespace Tumbleweed.Geometry.Spatial.Aabb.Size.Half;

public sealed class One : Envelope<Tumbleweed.Number.Real.Any>
{
	public One(Any space) : base
	(
		new QuotientByReal(
			new Whole.One(space), 2)
	)
	{
	}
}