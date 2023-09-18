using Tumbleweed.Object.Casted.Convertee;
using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using Object = Tumbleweed.Object;

namespace Tumbleweed.Enumerable;

public sealed class Unboxed : Enumerable::Envelope
{
	public Unboxed(System::Object @object) : this
	(
		new Scalar::With.Value(@object)
	)
	{
	}
	
	public Unboxed(Scalar::Any<System::Object> @object) : base
	(
		new Enumerable::Scalar.Value(
			new Object<System::Collections.IEnumerable>(@object))
	)
	{
	}
}