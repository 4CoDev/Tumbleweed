using Boolean = Tumbleweed.Boolean;
using Scalar = Tumbleweed.Scalar;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Boolean.Scalar;

public sealed class Value : Boolean::Any
{
	public Value(Scalar::Any<Boolean::Any> scalar) =>
		this.scalar = scalar;
	
	public System::Boolean State =>
		scalar.Value.State;

	private readonly Scalar::Any<Boolean::Any> scalar;
}