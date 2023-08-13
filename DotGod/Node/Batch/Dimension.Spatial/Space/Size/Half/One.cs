using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Size.Half;

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