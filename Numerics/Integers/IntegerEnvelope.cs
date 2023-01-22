using Tumbleweed.Bits;

namespace Tumbleweed.Numerics.Integers;

public abstract class IntegerEnvelope : IInteger
{
	protected IntegerEnvelope(IInteger integer)
	{
		this.integer = integer;
	}
	
	public IBit Positive
	{
		get => integer.Positive;
	}

	public IEnumerable<IBit> Natural
	{
		get => integer.Natural;
	}
	
	private readonly IInteger integer;
}