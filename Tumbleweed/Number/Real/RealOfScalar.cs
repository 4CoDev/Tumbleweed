using Tumbleweed.Number.Integer.Signed;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real;

public sealed class RealOfScalar : IReal
{
	public RealOfScalar(IScalar<IReal> scalar) =>
		this.scalar = scalar;
	
	public ISigned Mantissa => scalar.Value.Mantissa;

	public ISigned Base => scalar.Value.Base;

	public ISigned Exponent => scalar.Value.Exponent;

	private readonly IScalar<IReal> scalar;
}