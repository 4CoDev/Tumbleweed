using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;
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
		new One<Int32>(length)
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