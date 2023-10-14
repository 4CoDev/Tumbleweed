using Tumbleweed.Object.Casted.Convertee;
using Tumbleweed.Scalar.Immutable.With;
using System = System;

namespace Tumbleweed.Array.Dimension.Multi.System.Casted.Convertee;

public sealed class Object : Tumbleweed.Scalar.Immutable.Envelope<System::Array>
{
	public Object(System::Object @object) : this
	(
		new Value(@object)
	)
	{
	}
	
	public Object(Tumbleweed.Scalar.Immutable.Any<System::Object> scalar) : base
	(
		new Object<System::Array>(scalar)
	)
	{
	}
}