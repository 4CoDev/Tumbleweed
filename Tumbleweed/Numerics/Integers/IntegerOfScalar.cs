using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers;

public sealed class IntegerOfScalar : IInteger
{
	public IntegerOfScalar(IScalar<IInteger> scalar)
	{
		this.scalar = scalar;
	}

	public IBit Positive
	{
		get => scalar.Value.Positive;
	}
	
	public IEnumerable<IBit> Natural
	{
		get => scalar.Value.Natural;
	}
	
	private readonly IScalar<IInteger> scalar;
}