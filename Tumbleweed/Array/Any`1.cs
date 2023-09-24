using Tumbleweed.Mathematics.Number.Natural;
using Mutable = Tumbleweed.Scalar.Mutable;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Array;

public interface Any<T>
{
	Mutable::Any<T> this
	[
		SCG::IEnumerable<Any> indices
	]
	{ get; }
	
	SCG::IEnumerable<Any> Size { get; }
}