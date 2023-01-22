using Tumbleweed.Bits;
using Tumbleweed.Numerics.Bits.FromSystem;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Decimals.WithSystem;

public sealed class DecimalFromInt32 : IDecimal
{
	public DecimalFromInt32(IScalar<int> integer)
	{
		this.integer = integer;
	}

	public IBit Positive
	{
		get => new IsPositiveInt32(integer);
	}

	public IInteger Mantissa
	{
		get => throw new NotImplementedException();
	}

	public IInteger Exponent
	{
		get => throw new NotImplementedException();
	}

	private readonly IScalar<int> integer;
}