using Property = Tumbleweed.Property.Transput;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Array.Dimension.Multi;

public interface Any<T>
{
	Property::Any<T> this
	[ SCG::IEnumerable<Natural::Any> indices ]
	{ get; }
	
	SCG::IEnumerable<Natural::Any> Size { get; }
}