using Tumbleweed.Numbers.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real;

public sealed class RealOfScalar : IReal
{
	public RealOfScalar(IScalar<IReal> scalar) =>
		this.scalar = scalar;
	
	public ISigned Mantissa => scalar.Value.Mantissa;

	public ISigned Base => scalar.Value.Base;

	public ISigned Exponent => scalar.Value.Exponent;

	private readonly IScalar<IReal> scalar;
}