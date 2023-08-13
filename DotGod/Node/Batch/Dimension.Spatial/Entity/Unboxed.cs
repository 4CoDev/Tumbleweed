using DotGod.Node.Batch.Dimension.Spatial.Entity.Scalar.Value;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using Object = Tumbleweed.Object;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity;

public sealed class Unboxed : Envelope
{
	public Unboxed(System::Object @object) : this
	(
		new Scalar::With.Value<System::Object>(@object)
	)
	{
	}
	
	public Unboxed(Scalar::Any<System::Object> scalar) : base
	(
		new One(
			new Object::Unpacked<Any>(scalar))
	)
	{
	}
}