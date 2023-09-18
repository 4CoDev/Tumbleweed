using Scalar = Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Object.Casted.Convertee;

public sealed class Object<T> : Scalar::Envelope<T>
{
	public Object(System::Object convertee) : this
	(
		new Scalar::With.Value(convertee)
	)
	{
	}
	
	public Object
	(
		Scalar::Any<System::Object> scalar
	) : base
	(
		new Scalar::Function.Result.Actual<T>(
			() => (T) scalar.Value)
	)
	{
	}
}