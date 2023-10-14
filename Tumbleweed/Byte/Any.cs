using SCG = System.Collections.Generic;
using Boolean = Tumbleweed.Mathematics.Boolean;

namespace Tumbleweed.Byte;

public interface Any
{
	SCG::IEnumerable<Boolean::Any> Bits { get; }
}