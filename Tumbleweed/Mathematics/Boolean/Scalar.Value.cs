using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Scalar.Immutable;
using Boolean = Tumbleweed.Boolean;
using Scalar = Tumbleweed.Scalar;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Boolean.Scalar;

public sealed class Value : Any
{
	public Value(Any<Any> scalar) =>
		this.scalar = scalar;
	
	public System::Boolean State =>
		scalar.Value.State;

	private readonly Any<Any> scalar;
}