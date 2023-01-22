using Tumbleweed.Scalars;

namespace Tumbleweed.Bits;

public sealed class BitFromBoolean : IBit
{
	public BitFromBoolean(IScalar<bool> boolean)
	{
		State = boolean;
	}
	
	public IScalar<bool> State { get; }
}