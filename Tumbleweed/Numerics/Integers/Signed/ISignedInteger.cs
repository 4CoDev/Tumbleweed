using Tumbleweed.Bits;

namespace Tumbleweed.Numerics.Integers.Signed;

public interface ISignedInteger
{
	IBit Positive { get; }
	
	IEnumerable<IBit> Number { get; }
}