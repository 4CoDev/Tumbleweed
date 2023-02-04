using Tumbleweed.Numerics.Integers;

namespace Tumbleweed.Numerics.Decimals;

public abstract class DecimalEnvelope : IDecimal
{
	protected DecimalEnvelope(IDecimal @decimal)
	{
		this.@decimal = @decimal;
	}

	public IInteger Mantissa
	{
		get => @decimal.Mantissa;
	}
	
	public IInteger Exponent
	{
		get => @decimal.Exponent;
	}
	
	private readonly IDecimal @decimal;
}