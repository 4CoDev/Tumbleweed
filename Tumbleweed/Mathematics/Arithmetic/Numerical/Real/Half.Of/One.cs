using Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Product.Scalar.Of;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Half.Of;

public sealed class One : Envelope
{
	public One(Any whole) : base
	(
		new Multiple(
			whole,
			new Number.Real.Binary.Precision.Single.From.System.One(0.5F))
	)
	{
	}
}