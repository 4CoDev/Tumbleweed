using String = Tumbleweed.String;
using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.String.Property.Value;

public sealed class Actual : String::Any
{
	public Actual
	(
		Property::Any<String::Any> property
	)
	{
		this.property = property;
	}
	
	public System::String AsSystem =>
		property.Value.AsSystem;
	
	private readonly Property::Any<String::Any> property;
}