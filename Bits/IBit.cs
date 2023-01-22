using Tumbleweed.Scalars;

namespace Tumbleweed.Bits;

public interface IBit
{
	IScalar<bool> State { get; }
}