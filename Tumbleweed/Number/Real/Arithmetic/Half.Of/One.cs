using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Number.Real.Arithmetic.Half.Of;

public sealed class One : Real::Envelope
{
	public One(Real::Any whole) : base
	(
		new Real::Arithmetic.Product.Scalar.Of.Multiple(
			whole,
			new Real::Binary.Precision.Single.From.System.One(0.5F))
	)
	{
	}
}