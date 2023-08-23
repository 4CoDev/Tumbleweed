using Mutable = Tumbleweed.Scalar.Mutable;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;

namespace Tumbleweed.Array;

public interface Any<T>
{
	Mutable::Any<T> this
	[
		SCG::IEnumerable<Natural::Any> indices
	]
	{ get; }
	
	SCG::IEnumerable<Natural::Any> Size { get; }
}