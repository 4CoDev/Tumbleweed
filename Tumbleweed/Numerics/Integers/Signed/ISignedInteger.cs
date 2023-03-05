using Tumbleweed.Bits;
using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Numerics.Integers.Signed;

public interface ISignedInteger
{
	IBit Positive { get; }
	
	INaturalInteger Natural { get; }
}