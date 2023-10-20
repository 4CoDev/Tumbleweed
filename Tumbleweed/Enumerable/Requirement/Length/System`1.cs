using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using Enumerable = Tumbleweed.Enumerable;
using System = System;

namespace Tumbleweed.Enumerable.Requirement.Length;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		IEnumerable<T> enumerable,
		System::Int32 length
	) : this
	(
		enumerable,
		new Value<Int32>(length)
	)
	{
	}
	
	public System
	(
		IEnumerable<T> enumerable,
		Any<System::Int32> length
	) : base
	(
		new Collection.Requirement.Length.System<T>(
			new List<T>(enumerable),
			length)
	)
	{
	}
}