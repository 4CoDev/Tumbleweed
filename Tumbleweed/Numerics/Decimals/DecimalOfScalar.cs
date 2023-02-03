using Tumbleweed.Numerics.Integers;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Decimals;

public sealed class DecimalOfScalar : IDecimal
{
	public DecimalOfScalar(IScalar<IDecimal> scalar)
	{
		this.scalar = scalar;
	}
	
	public IInteger Mantissa
	{
		get => scalar.Value().Mantissa;
	}

	public IInteger Exponent
	{
		get => scalar.Value().Exponent;
	}
	
	private readonly IScalar<IDecimal> scalar;
}