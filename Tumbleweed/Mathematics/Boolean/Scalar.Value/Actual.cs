using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Boolean.Scalar.Value;

public sealed class Actual : Any
{
	public Actual(Any<Any> scalar) =>
		this.scalar = scalar;
	
	public System::Boolean State =>
		scalar.Value.State;

	private readonly Any<Any> scalar;
}