using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Spatial.Point.Real.Arithmetic;

public sealed class QuotientByReal : PointEnvelope<IReal>
{
	public QuotientByReal
	(
		IPoint<IReal> dividend,
		Single divisor
	) : this
	(
		dividend,
		new RealFromSingle(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		IPoint<IReal> dividend,
		IScalar<Single> divisor
	) : this
	(
		dividend,
		new RealFromSingle(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		IPoint<IReal> dividend,
		Double divisor
	) : this
	(
		dividend,
		new RealFromDouble(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		IPoint<IReal> dividend,
		IScalar<Double> divisor
	) : this
	(
		dividend,
		new RealFromDouble(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		IPoint<IReal> dividend,
		IReal divisor
	) : base
	(
		new QuotientOfPoints(
			dividend,
			new UniformWithCoordinate<IReal>(divisor))
	)
	{
	}
}