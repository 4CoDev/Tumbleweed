using Tumbleweed.Bits;

namespace Tumbleweed.Numerics.Integers;

public sealed class IntegerWithValues : IInteger
{
	public IntegerWithValues(IBit positive, IEnumerable<IBit> bits)
	{
		Positive = positive;
		Natural = bits;
	}
	
	public IBit Positive { get; }
	
	public IEnumerable<IBit> Natural { get; }
}