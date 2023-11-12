using String = Tumbleweed.String;
using System = System;
using Enumerable =  Tumbleweed.Enumerable;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.String;

public sealed class Conсatenated : String::Envelope
{
	public Conсatenated(params System::String[] strings) : this
	(
		new String::From.System.NonNullable.Multiple(strings)
	)
	{
	}
	
	public Conсatenated(params String::Any[] strings) : this
	(
		new Enumerable::Concatenated<Any>(strings)
	)
	{
	}
	
	public Conсatenated(IEnumerable<String::Any> strings) : this
	(
		new Enumerable::Selected
			<String::Any, System::String>
			(strings, @string => @string.AsSystem)
	)
	{
	}
	
	public Conсatenated(IEnumerable<System::String> strings) : base
	(
		new String::From.System.NonNullable.One(
			new Property::Function.Result.Actual<System::String>(
				() => System::String.Concat(strings)))
	)
	{
	}
}