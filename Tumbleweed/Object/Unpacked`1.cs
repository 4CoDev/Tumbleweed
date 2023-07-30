using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Object;

public sealed class Unpacked<T> : Envelope<T>
{
	public Unpacked(System::Object @object) : this
	(
		new Value(@object)
	)
	{
	}
	
	public Unpacked(Any<System::Object> scalar) : base
	(
		new Actual<T>(
			() => (T) scalar.Value)
	)
	{
	}
}