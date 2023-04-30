using Tumbleweed.Booleans;

namespace Tumbleweed.Numbers.Integers.Natural;

public interface INatural
{
	IEnumerable<IBoolean> Bits { get; }
}