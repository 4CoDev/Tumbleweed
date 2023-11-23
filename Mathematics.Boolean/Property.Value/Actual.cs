using Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Mathematics.Boolean.Property.Value;

public sealed class Actual : Any
{
	public Actual(Any<Any> property) =>
		this.property = property;
	
	public System::Boolean State =>
		property.Value.State;

	private readonly Any<Any> property;
}