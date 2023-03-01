using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;

namespace Tumbleweed.Numerics.Fractional;

public interface IFractional
{
	ISignedInteger Mantissa { get; }
	
	ISignedInteger Base { get; }
	
	ISignedInteger Exponent { get; }
}