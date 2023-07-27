using Mutable = Tumbleweed.Mutable;
using Natural = Tumbleweed.Number.Natural;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array;

public interface Any<T>
{
	Mutable::Any<T> this[IEnumerable<Natural::Any> indices] { get; }
	
	SCG::IEnumerable<Natural::Any> Size { get; }
}