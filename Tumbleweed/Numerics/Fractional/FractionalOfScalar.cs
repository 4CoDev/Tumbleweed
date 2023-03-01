using Tumbleweed.Bits;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional;

public sealed class FractionalOfScalar : IFractional
{
	public FractionalOfScalar(IScalar<IFractional> scalar) =>
		this.scalar = scalar;
	
	public ISignedInteger Mantissa => scalar.Value.Mantissa;

	public ISignedInteger Base => scalar.Value.Base;

	public ISignedInteger Exponent => scalar.Value.Exponent;

	private readonly IScalar<IFractional> scalar;
}