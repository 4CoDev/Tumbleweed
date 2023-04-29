using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Numerics.Integers.Signed;

public interface ISignedInteger
{
	IBoolean Positive { get; }
	
	INaturalInteger Natural { get; }
}